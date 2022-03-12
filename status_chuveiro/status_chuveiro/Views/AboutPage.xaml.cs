using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace status_chuveiro.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void definirtempo(object sender, CheckedChangedEventArgs e)
        {
            //RadioButton novo = sender as RadioButton;
            txttempo.Text = "Definindo Tempo!";
            txtstatus.Text = "Para iniciar o banho clique no botão acima";

        }

        private void buttonClick(object sender, EventArgs e)
        {
            txtstatus.Text = "CHUVEIRO OCUPADO";
        }
    }
}