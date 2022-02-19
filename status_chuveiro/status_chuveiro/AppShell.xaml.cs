using status_chuveiro.ViewModels;
using status_chuveiro.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace status_chuveiro
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
