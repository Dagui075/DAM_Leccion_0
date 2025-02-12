using DAM_Leccion_DAO.View;

namespace DAM_Leccion_DAO
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();
            MainPage = new PersonasView();
        }


    }
}
