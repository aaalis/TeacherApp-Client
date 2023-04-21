using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
                login = value;
                SetProperty(ref login, value);
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                SetProperty(ref password, value);
            }
        }


        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // вызов метода авторизации 
            bool successAuth = true; //HttpClient.GetAsync...

            if (successAuth)
            {
                SaveCredentials();
            }

            await Shell.Current.GoToAsync($"//{nameof(LessonPage)}");
        }

        private void SaveCredentials()
        {
            //FileService
        }
    }
}
