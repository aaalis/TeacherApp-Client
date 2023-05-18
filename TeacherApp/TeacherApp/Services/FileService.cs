using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using PCLAppConfig;
using TeacherApp.Models;

namespace TeacherApp.Services
{
    public class FileService
    {
        private readonly string fileName = "authUser.json";

		private string filePath;
		public string FilePath
		{
			get { return filePath; }
			set { filePath = value; }
		}

		public FileService()
		{
			FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), fileName);
		}

        /// <summary>
        /// Сохранение данных для авторизации, с помощью которых была выполнена авторизация в последний раз.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        public void SaveCredentials(string login, string pass)
		{
            string encryptedPass = Encrypt(pass,
                                           ConfigurationManager.AppSettings["PassPhrase"],
                                           ConfigurationManager.AppSettings["SaltValue"], 
                                           ConfigurationManager.AppSettings["HashAlgorithm"], 
                                           Int32.Parse(ConfigurationManager.AppSettings["PassIterations"]), 
                                           ConfigurationManager.AppSettings["InitVector"], 
                                           Int32.Parse(ConfigurationManager.AppSettings["Key"]));
            
            var user = new User() { Login = login, Password = encryptedPass };

            File.WriteAllText(FilePath, JsonConvert.SerializeObject(user));
		}

		/// <summary>
        /// Выгрузка данных для авторизация, с помощью которых была выполнена авторизация в последний раз.
        /// </summary>
        public User GetCredentials()
		{
            if (File.Exists(FilePath))
            {
                User user;

                using (StreamReader stream = File.OpenText(FilePath))
                {
                    var content = stream.ReadToEnd();

                    user = JsonConvert.DeserializeObject<User>(content);
                }

                user.Password = Decrypt(user.Password,
                                        ConfigurationManager.AppSettings["PassPhrase"],
                                        ConfigurationManager.AppSettings["SaltValue"],
                                        ConfigurationManager.AppSettings["HashAlgorithm"],
                                        Int32.Parse(ConfigurationManager.AppSettings["PassIterations"]),
                                        ConfigurationManager.AppSettings["InitVector"],
                                        Int32.Parse(ConfigurationManager.AppSettings["Key"]));

                return user;
            }

            return null;
        }

        /// <summary>
        /// Метод шифрования
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="passPhrase">Парольная фраза, из которой будет выведен псевдослучайный пароль. 
        /// Полученный пароль будет использоваться для создания ключа шифрования. 
        /// Парольная фраза может быть любой строкой</param>
        /// <param name="saltValue">Значение соли, используемое вместе с парольной фразой для создания пароля. Соль может быть любой строкой.</param>
        /// <param name="hashAlgorithm">Алгоритм хэширования, используемый для генерации пароля. Допустимые значения: «MD5″ и » SHA256”</param>
        /// <param name="passIterations">Количество итераций, используемых для создания пароля.</param>
        /// <param name="initVector"> Вектор инициализации (или IV). Это значение необходимо для шифрования первого блока текстовых данных.</param>
        /// <param name="key">размер ключа шифрования в битах. Допустимые значения: 128, 192 и 256.</param>
        /// <returns></returns>
        private string Encrypt(string plainText, 
							   string passPhrase,
							   string saltValue,
							   string hashAlgorithm,
							   int passIterations,
							   string initVector,
							   int key)
		{
            //Преобразование строк в байтовые массивы.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            //Преобразование открытого текста в массив байтов.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            //Создание пароля, из которого будет получен ключ.
            //Этот пароль будет создан из указанной парольной фразы и
            //соли. Пароль будет создан с использованием указанного хэша
            //алгоритма. Создание пароля может выполняться в нескольких итерациях.
            PasswordDeriveBytes password = new PasswordDeriveBytes
            (
                passPhrase,
                saltValueBytes,
                hashAlgorithm,
                passIterations
            );

            //Пароль для создания псевдослучайных байтов для шифрования
            //ключа нужно указывать байтах (вместо битов).
            byte[] keyBytes = password.GetBytes(key / 8);

            //Создание неинициализированного объекта шифрования Rijndael.
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            //Создание шифратора из существующих байтов ключа и инициализации
            //вектор. Размер ключа определяется на основе количества байтов ключа.
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor
            (
                keyBytes,
                initVectorBytes
            );

            string cipherText;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

                    //Шифровка конца.
                    cryptoStream.FlushFinalBlock();

                    //Преобразование зашифрованных данных из потока памяти в массив байтов.
                    byte[] cipherTextBytes = memoryStream.ToArray();
                    
                    //Преобразование зашифрованных данных в строку в кодировке base64.
                    cipherText = Convert.ToBase64String(cipherTextBytes);
                }
            }

            return cipherText;
        }

        /// <summary>
        /// Метод дешифрования
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="passPhrase">Парольная фраза, из которой будет выведен псевдослучайный пароль. 
        /// Полученный пароль будет использоваться для создания ключа шифрования. 
        /// Парольная фраза может быть любой строкой</param>
        /// <param name="saltValue">Значение соли, используемое вместе с парольной фразой для создания пароля. Соль может быть любой строкой.</param>
        /// <param name="hashAlgorithm">Алгоритм хэширования, используемый для генерации пароля. Допустимые значения: «MD5″ и » SHA256”</param>
        /// <param name="passIterations">Количество итераций, используемых для создания пароля.</param>
        /// <param name="initVector"> Вектор инициализации (или IV). Это значение необходимо для шифрования первого блока текстовых данных.</param>
        /// <param name="key">размер ключа шифрования в битах. Допустимые значения: 128, 192 и 256.</param>
        /// <returns></returns>
        private string Decrypt(string cipherText,
                               string passPhrase, 
                               string saltValue, 
                               string hashAlgorithm, 
                               int passIterations,
                               string initVector,
                               int key)
        {
            //Преобразование строк, определяющих характеристики ключа шифрования, в байтовые массивы.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);

            //Преобразование зашифрованного текста в массив байтов.
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            //Создание пароль, из которого будет получен ключ
            //Этот пароль будет создан из указанной парольной фразы и значения соли.
            //Пароль будет создан с использованием указанного алгоритма хэша. Создание пароля может выполняться в нескольких итерациях.
            PasswordDeriveBytes password = new PasswordDeriveBytes
            (
                passPhrase,
                saltValueBytes,
                hashAlgorithm,
                passIterations
            );

            //Пароль для создания псевдослучайных байтов для шифрования
            //ключа нужно указывать байтах (вместо битов).
            byte[] keyBytes = password.GetBytes(key / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            //Создание дешифратора из существующих байтов ключа и инициализации
            //вектора. Размер ключа определяется на основе номера ключа
            //байты.
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor
            (
                keyBytes,
                initVectorBytes
            );

            string plainText;

            using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                    int decryptedByteCount = cryptoStream.Read(plainTextBytes,0 ,plainTextBytes.Length);

                    //Преобразование расшифрованных данных в строку.
                    plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                }
            }
            
            return plainText;
        }
	}
}
