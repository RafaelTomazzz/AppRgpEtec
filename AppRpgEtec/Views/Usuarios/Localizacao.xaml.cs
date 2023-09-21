
using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class Localizacao : ContentPage
{
	LocalizacaoViewModel viewModel;
	public Localizacao()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
		//viewModel.InicializarMapa();
		viewModel.ExibirUsuariosNoMapa();

		BindingContext = viewModel;
	}
}