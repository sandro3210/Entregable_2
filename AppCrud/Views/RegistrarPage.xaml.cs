using AppCrud.Models;

namespace AppCrud.Views;

public partial class RegistrarPage : ContentPage
{
    Usuario _usuario;
    public RegistrarPage()
    {
        InitializeComponent();
        _usuario = new Usuario();
        this.BindingContext = _usuario;
    }
    private async void btnRegistrar_click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_usuario.User) &&
           string.IsNullOrWhiteSpace(_usuario.Contraseña))
        {
            await DisplayAlert("alerta", "no se permiten campos vacios", "ok");
            return;
        }
        var registrar = await App.BaseDatos.UsuarioDataTable.GuardarUsuario(_usuario);
        if (registrar > 0)
        {
            await Navigation.PopAsync();
        }

    }
    private async void btnVolver_click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}