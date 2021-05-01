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
    public partial class Resumen : ContentPage
    {
        public Resumen(String nombre, String mensual, String user)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblMensual.Text = mensual;
            lblUser.Text = user;
        }
    }
}