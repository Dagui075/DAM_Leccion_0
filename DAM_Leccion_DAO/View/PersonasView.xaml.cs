using DAM_Leccion_DAO.ViewModel;

namespace DAM_Leccion_DAO.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();
		BindingContext = new PersonasViewModel();
	}
}