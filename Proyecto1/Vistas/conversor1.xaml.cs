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
	public partial class conversor1 : ContentPage
	{

		double cm;
		double m;
		public conversor1 ()
		{
			InitializeComponent();
		}
		private void calcular()
		{
			cm = Convert.ToDouble(barraNum.Text);
			m = cm / 100;
			Resultado.Text = m.ToString() + " m";

		}
		private void validar()
		{
			if (!string.IsNullOrEmpty(barraNum.Text)) 
			{
				calcular();

			}
			else
			{
				DisplayAlert("Error", "Ingrese una cantidad", "OK");
			}
		}
		
		

        private void btncentimetro_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

        private void Proceso_Clicked(object sender, EventArgs e)
        {
			validar();
        }
    }
	
	

}