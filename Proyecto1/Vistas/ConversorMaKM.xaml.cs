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
    public partial class ConversorMaKM : ContentPage
    {
        private double m;
        private double km;

        private void proceso()
        {
            m = Convert.ToDouble(Valor.Text);
            km = m / 1000;
            Resultado.Text = km.ToString() + " Km";
        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(Valor.Text))
            {
                proceso();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }
        public ConversorMaKM()
        {
            InitializeComponent();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}