using DAM_Leccion_DAO.Model;
using DAM_Leccion_DAO.ViewModel;

namespace DAM_Leccion_DAO
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel MainPageviewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = MainPageviewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se a guardado el reistro de la BD", "Aceptar");
        }
    }

}
