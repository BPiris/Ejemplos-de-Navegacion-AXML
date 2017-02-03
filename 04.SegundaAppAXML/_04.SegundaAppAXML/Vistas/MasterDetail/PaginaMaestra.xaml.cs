using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using _04.SegundaAppAXML.Model;

namespace _04.SegundaAppAXML.Vistas.MasterDetail
{
    public partial class PaginaMaestra : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public PaginaMaestra()
        {
            InitializeComponent();

            var elementosMasterPage = new List<ElementoMasterPageModel>();

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Simple",
                EnlacePagina = typeof(Inicio)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Tabbed",
                EnlacePagina = typeof(InicioTabbed)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Carrousel",
                EnlacePagina = typeof(InicioCarrousel)
            });

            listView.ItemsSource = elementosMasterPage;
        }
    }
}
