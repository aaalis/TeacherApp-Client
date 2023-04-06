using System.ComponentModel;
using TeacherApp.ViewModels;
using Xamarin.Forms;

namespace TeacherApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}