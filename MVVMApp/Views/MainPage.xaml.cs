using MVVMApp.ViewModels;

namespace MVVMApp;

public partial class MainPage : ContentPage
{

	public MainPage(ParticipanteViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
	public void Completed(object sender, EventArgs args)
	{
		entryName.Unfocus();
		entrySobrenome.Focus();
		lblMensagem.Text=String.Empty;
	}

	public void CompletedSobrenome(object sender, EventArgs args)
	{
		btnInserirNome.Command.Execute(btnInserirNome);
		entrySobrenome.Unfocus();
		entryName.Focus();
	}
}

