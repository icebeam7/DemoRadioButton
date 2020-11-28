namespace DemoRadioButton.ViewModels
{
    public class DesempeñoViewModel : BaseViewModel
    {
        private int valoracion;

        public int Valoracion
        {
            get => valoracion; 
            set { valoracion = value; OnPropertyChanged(); }
        }

        public DesempeñoViewModel()
        {
            Valoracion = 2;
        }
    }
}
