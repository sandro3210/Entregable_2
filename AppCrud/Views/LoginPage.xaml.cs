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
		string contraseña = txtContraseña.Text;

		if (!string.IsNullOrWhiteSpace(usuario) &&
			!string.IsNullOrWhiteSpace(usuario))
		{
			var usuarios = await App.BaseDatos.UsuarioDataTable.ObtenUsuario(usuario, contraseña);

			if (usuarios == null)
			{
				await DisplayAlert("atencioooon", "usuario y contraseña invalidados", "ok");
				return;	
			}
			App.Usuario = usuarios;
			Navigation.PushAsync(new HomePage());

		}
    }
}