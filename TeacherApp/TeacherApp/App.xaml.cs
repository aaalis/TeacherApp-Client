using PCLAppConfig;
using System;
using TeacherApp.Models.Intefaces;
using TeacherApp.Services;
using TeacherApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("RobotoSlab-Light.ttf", Alias = "RobotoSlab")]

namespace TeacherApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            App.Current.UserAppTheme = OSAppTheme.Light;

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
