﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradesPage : ContentPage
    {
        public GradesPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            BindingContext = new GradesViewModel();
        }
        
    }
}