using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto1.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menuprincipal : ContentPage
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        

        private void btnPricipal_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Opciones());
        }
    }
}