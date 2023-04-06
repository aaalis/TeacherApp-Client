using System;
using TeacherApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
