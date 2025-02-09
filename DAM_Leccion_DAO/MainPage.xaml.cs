using DAM_Leccion_DAO.Model;

namespace DAM_Leccion_DAO
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public PersonaModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
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

        public void Ejecutar()
        {
            personaModel = new PersonaModel()
            {
                Nombre = "Hola aqui estoy",
            };
            BindingContext = personaModel.Nombre;
            //txtNombre.Text = personaModel.Nombre;

            //Binding personaBinding = new Binding();

            //personaBinding.Source = personaModel;//Origen
            //personaBinding.Path = "Nombre";//Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding);//Destino Final




        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se a guardado el reistro de la BD", "Aceptar");
            personaModel.Nombre = "Muñeco";
        }
    }

}
