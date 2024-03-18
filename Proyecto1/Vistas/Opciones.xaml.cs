using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opciones : ContentPage
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btncm_m_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new conversor1());
        }

        private void Atras_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnMaCm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorMaCM());            
        }

        private void btmCMaP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorCMaP());
        }

        private void btnPaCM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorPaCM());
        }

        private void btmMaKM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorMaKM());
        }

        private void btnKMaM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConversorKMaM());
        }
    }
}