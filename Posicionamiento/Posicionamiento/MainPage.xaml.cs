using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Posicionamiento
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var Nombres = Nombre.Text;
            string Critica = "";
            
            if (Hombre.IsChecked == true)
            {
                if(FEO.IsChecked == true)
                {
                    Critica += "feo ";
                }
                if(ALTO.IsChecked == true)
                {
                    Critica += "alto ";
                }
                if (LISTO.IsChecked == true)
                {
                    Critica += "listo ";
                }
                if (EXTRAVAGANTE.IsChecked == true)
                {
                    Critica += "extravagante ";
                }
                if (RARO.IsChecked == true)
                {
                    Critica += "raro ";
                }
                if (GRANDE.IsChecked == true)
                {
                    Critica += "grande ";
                }

            }
            else if(Mujer.IsChecked == true)
            {
                if (FEO.IsChecked == true)
                {
                    Critica += "fea ";
                }
                if (ALTO.IsChecked == true)
                {
                    Critica += "alta ";
                }
                if (LISTO.IsChecked == true)
                {
                    Critica += "lista ";
                }
                if (EXTRAVAGANTE.IsChecked == true)
                {
                    Critica += "extravagante ";
                }
                if (RARO.IsChecked == true)
                {
                    Critica += "rara ";
                }
                if (GRANDE.IsChecked == true)
                {
                    Critica += "grande ";
                }
            }

            string aux = string.Empty;
            string[] subs = Critica.Split(' ');
            for (int i = 0; i < subs.Length-1; i++)
            {
                
                if (i < subs.Length-3)
                {
                    aux += subs[i] + ", ";

                }
                else if (i == subs.Length - 3)
                {
                    aux += subs[i] + " y ";

                }
                else if (i == subs.Length-2)
                {
                    aux +=  subs[i]+".";
                }
                
            }
            //string prueba = subs[cont-2];

            Critica = string.Empty;
            Critica = Nombres + " es " + aux;

            Resultado.Text = Critica;
        }




    }
}
