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
	public partial class ConversorPaCM : ContentPage
	{
		private double p;
		private double cm;
		public ConversorPaCM ()
		{
			InitializeComponent ();
		}
		private void Proceso()
		{
			p = Convert.ToDouble(Valor.Text);
			cm = p * 2.54;
			Resultado.Text = cm.ToString() + " Cm";
		}
		private void Validar()
		{
			if(!string.IsNullOrEmpty(Valor.Text))
			{
				Proceso();
			}
			else
			{
				DisplayAlert("Error", "Ingrese una cantidad", "OK");
			}
		}

        private void VolverAtras_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
			Validar();
        }
    }
}