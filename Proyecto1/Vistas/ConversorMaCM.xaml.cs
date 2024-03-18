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
	public partial class ConversorMaCM : ContentPage
	{
		double m;
		double cm;
		public ConversorMaCM ()
		{
			InitializeComponent ();
		}
		private void operancion()
		{
			m = Convert.ToDouble(proceso.Text);
			cm = m * 100;
			Resultado.Text = cm.ToString() + "cm";
		}
		private void validar()
		{
			if (!string.IsNullOrEmpty(proceso.Text))
			{
				operancion();
			}
			else
			{
				DisplayAlert("Error", "Ingrese una cantidad", "OK");
			}
		}

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
			validar();
        }
    }
}