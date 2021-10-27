using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S3T3NejerDavid
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUser.Text = "Bienvenido " + usuario;
            DisplayAlert("Saludo", "Bienvenido " + usuario, "Ok");
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtValorUno.Text);
                double n2 = Convert.ToDouble(txtValorDos.Text);
                double res = n1 + n2;
                txtResultado.Text = Convert.ToString(res);


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "ok");
            }
        }
    }
}