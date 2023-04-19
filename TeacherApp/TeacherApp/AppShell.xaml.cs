using System;
using System.Collections.Generic;
using TeacherApp.ViewModels;
using TeacherApp.Views;
using Xamarin.Forms;

namespace TeacherApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LessonPage), typeof(LessonPage));
            Routing.RegisterRoute(nameof(GradesPage), typeof(GradesPage));
            Routing.RegisterRoute(nameof(StudentsPage), typeof(StudentsPage));
            Routing.RegisterRoute(nameof(TimetablePage), typeof(TimetablePage));
        }

    }
}
