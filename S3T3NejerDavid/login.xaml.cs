using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3T3NejerDavid
{
   
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                string clave = "estudiante2021";
                string user = "uisrael2021";
                if (clave == txtClave.Text && user == txtUsuario.Text)
                {
                    await Navigation.PushAsync(new MainPage(txtUsuario.Text));
                }
                else
                {
                    await DisplayAlert("Alerta", "Credenciales Incorrectas", "Ok");
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Alerta", ex.Message, "Ok");
                throw;
            }

        }
    }
}