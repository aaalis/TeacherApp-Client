using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;
using TeacherApp.Views;
using Xamarin.Forms;

namespace TeacherApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                SetProperty(ref login, value);
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                SetProperty(ref password, value);
            }
        }

        private bool warning;
        public bool Warning
        {
            get { return warning; }
            set 
            { 
                warning = value;
                OnPropertyChanged();// Boolean значение не работает с методом SetProperty
                //SetProperty(ref warning, value);
            }
        }


        public FileService FileService { get; }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            FileService = new FileService();
            Warning = false;
            Password = "";
            Login = "";

            LoadCredentials();
        }

        private async void OnLoginClicked(object obj)
        {
            // вызов метода авторизации 
            bool successAuth = true; //HttpClient.GetAsync...

            if (Validating () && successAuth)
            {
                FileService.SaveCredentials(Login, Password);

                LoadLessons();

                await Shell.Current.GoToAsync($"//{nameof(LessonPage)}");
            }
        }

        /// <summary>
        /// Валидация введенных данных
        /// </summary>
        /// <returns></returns>
        private bool Validating()
        {
            if (Password.Length > 0 && Login.Length > 0)
            {
                Warning = false;
                return true;
            }

            Warning = true;
            return false;
        }

        /// <summary>
        /// Загрузка ранее введенных данных для авторизации
        /// </summary>
        private void LoadCredentials()
        {
            var user = FileService.GetCredentials();

            if (user == null)
            {
                return;
            }

            Login = user.Login;
            Password = user.Password;
        }


        private void LoadLessons()
        {
            CurrentLesson.Instance().Update(MockDataStore.Lessons[0]);
        }
    }
}
