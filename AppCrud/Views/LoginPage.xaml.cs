namespace AppCrud.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	private void btnRegistrar_click(object sender, EventArgs e) { 
		Navigation.PushAsync(new RegistrarPage());
	}
    private async void btnIniciar_click(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrase�a = txtContrase�a.Text;

		if (!string.IsNullOrWhiteSpace(usuario) &&
			!string.IsNullOrWhiteSpace(usuario))
		{
			var usuarios = await App.BaseDatos.UsuarioDataTable.ObtenUsuario(usuario, contrase�a);

			if (usuarios == null)
			{
				await DisplayAlert("atencioooon", "usuario y contrase�a invalidados", "ok");
				return;	
			}
			App.Usuario = usuarios;
			Navigation.PushAsync(new HomePage());

		}
    }
}