using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace _04.SegundaAppAXML.Vistas
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            btnInicioLogin.Clicked += (sender, args) =>
            {
                Navigation.PushModalAsync(new InicioPaginaDetalle());
            };
        }        
    }
}
