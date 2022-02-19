using status_chuveiro.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace status_chuveiro.Views
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