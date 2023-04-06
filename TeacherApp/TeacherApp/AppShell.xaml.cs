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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
