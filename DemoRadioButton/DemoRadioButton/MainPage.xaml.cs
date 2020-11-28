using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoRadioButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void rb_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var rb = (RadioButton)sender;
                var mensaje = string.Empty;

                switch (rb.Value.ToString())
                {
                    case "Zlin":
                        mensaje = "No, pero ahí vivo. ¡Visítame un día!";
                        break;
                    case "Brno":
                        mensaje = "No, pero es la segunda ciudad más grande del país.";
                        break;
                    case "Praga":
                        mensaje = "¡Correcto! Y también es conocida como \"La ciudad de las cien torres\"";
                        break;
                    case "Plzen":
                        mensaje = "No, pero ahí hacen una buena cerveza. Na zdraví!";
                        break;
                }

                await DisplayAlert("Resultado", mensaje, "OK");
            }
        }

    }
}
