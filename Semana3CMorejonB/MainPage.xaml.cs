using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3CMorejonB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_ventana_dos_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            await Navigation.PushAsync(new Ventana2(user,password));
        }
    }
}
