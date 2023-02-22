using Ejercicio1_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        Operaciones operaciones;
        public MainPage()
        {
            InitializeComponent();

            operaciones = new Operaciones();
        }

        private void btnsuma_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Views.Resultado());

            operaciones.Num1 = double.Parse(num1.Text);
            operaciones.Num2 = double.Parse(num2.Text);

            var resultado = operaciones.Suma();

            Navigation.PushAsync(new Views.Resultado(resultado.ToString()));
        }

        private void btnresta_Clicked(object sender, EventArgs e)
        {
            operaciones.Num1 = double.Parse(num1.Text);
            operaciones.Num2 = double.Parse(num2.Text);

            var resultado = operaciones.Resta();

            Navigation.PushAsync(new Views.Resultado(resultado.ToString()));
        }

        private void btndivi_Clicked(object sender, EventArgs e)
        {

            if (double.Parse(num2.Text) == 0)
            {
                var resultado = "No se puede dividir entre cero";

                Navigation.PushAsync(new Views.Resultado(resultado));
            }
            else
            {
                operaciones.Num1 = double.Parse(num1.Text);
                operaciones.Num2 = double.Parse(num2.Text);

                var resultado = operaciones.Division();

                Navigation.PushAsync(new Views.Resultado(resultado.ToString()));
            }
        }

        private void btnmulti_Clicked(object sender, EventArgs e)
        {
            operaciones.Num1 = double.Parse(num1.Text);
            operaciones.Num2 = double.Parse(num2.Text);

            var resultado = operaciones.Multiplicacion();

            Navigation.PushAsync(new Views.Resultado(resultado.ToString()));
        }
    }
}
