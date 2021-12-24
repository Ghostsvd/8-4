using but.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace but.Views
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