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
	public partial class ConversorCMaP : ContentPage
	{
		double cm;
		double p;
		
		private void calcular() 
		{
			cm = Convert.ToDouble(valor.Text);
			p = cm / 2.74;
		    Resultado.Text = p.ToString() + " p";
		}
		private void validar()
		{
			if(!string.IsNullOrEmpty(valor.Text))
			{
				calcular();
			}
			else
			{
				DisplayAlert("Error", "Ingrese una cantidad", "OK");
			}
		}
		public ConversorCMaP ()
		{
			InitializeComponent ();
		}

        private void Volver_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void Convertir_Clicked(object sender, EventArgs e)
        {
			validar();
        }
    }
}