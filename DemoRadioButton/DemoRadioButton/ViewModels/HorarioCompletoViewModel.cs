using System.Windows.Input;
using Xamarin.Forms;

namespace DemoRadioButton.ViewModels
{
    public class HorarioCompletoViewModel : BaseViewModel
    {
        private string mes;

        public string Mes
        {
            get => mes; 
            set { mes = value; OnPropertyChanged(); OnPropertyChanged("Seleccion"); }
        }

        private string dia;

        public string Dia
        {
            get => dia; 
            set { dia = value; OnPropertyChanged(); OnPropertyChanged("Seleccion"); }
        }

        private string hora;

        public string Hora
        {
            get => hora; 
            set { hora = value; OnPropertyChanged(); OnPropertyChanged("Seleccion"); }
        }

        public string Seleccion { get => $"{ Mes } - {Dia} - {Hora}"; }
    }
}
