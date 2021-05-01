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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtPasword.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
                //await Navigation.PushAsync(new Registro(usuario));
                await Navigation.PushAsync(new Registro(usuario));
            else
                await DisplayAlert("Advertencia", "Usuario y/o Contraseña son incorrectas", "OK");
        }
    }
}