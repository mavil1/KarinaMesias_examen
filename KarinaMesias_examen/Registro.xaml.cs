using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KarinaMesias_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;

        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double pago = Convert.ToDouble(txtPagoinicial.Text);
            double rest = (1800 - pago) / 3;
            double total = (rest * 0.05) * 3 + 1800;
            txtTotal.Text = total.ToString();

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            await DisplayAlert("GUARDAR", "Elemento guardado con éxito", "OK");

            string nombre = txtNombre.Text;
            string mensual = txtTotal.Text;
            string user = lblUsuario.Text;
            await Navigation.PushAsync(new Resumen(nombre, mensual, user));

        }

    }
}