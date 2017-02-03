using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using _04.SegundaAppAXML.Model;

namespace _04.SegundaAppAXML.Vistas
{
    public partial class InicioPaginaDetalle : MasterDetailPage
    {
        public InicioPaginaDetalle()
        {
            InitializeComponent();

            miPaginaMaestra.ListView.ItemSelected += OnItemSelected;

            NavigationPage.SetHasNavigationBar(this, false);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ElementoMasterPageModel;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.EnlacePagina));
                miPaginaMaestra.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
