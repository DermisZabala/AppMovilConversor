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
    public partial class ConversorKMaM : ContentPage
    {
        private double km;
        private double m;

        private void proceso()
        {
            km = Convert.ToDouble(Valor.Text);
            m = km * 1000;
            Resultado.Text = m.ToString() + " m"; 
        }
        private void Validar()
        {
            if(!string.IsNullOrEmpty(Valor.Text))
            {
                proceso();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }
        public ConversorKMaM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}