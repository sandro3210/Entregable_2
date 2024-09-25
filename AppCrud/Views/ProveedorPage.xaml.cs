using AppCrud.Models;

namespace AppCrud.Views;

public partial class ProveedorPage : ContentPage
{
    Proveedor _proveedor;

    public ProveedorPage()
    {
        InitializeComponent();
        _proveedor = new Proveedor();
        this.BindingContext = _proveedor;
    }
    private async void btnGuardarProveedor_click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_proveedor.NombreProveedor) &&
           string.IsNullOrWhiteSpace(_proveedor.TelefonoProveedor))
        {
            await DisplayAlert("alerta", "no se permiten campos vacios", "ok");
            return;
        }
        var guardar = await App.BaseDatos.ProveedorDataTable.GuardarProveedor(_proveedor);
        if (guardar > 0)
        {
            Navigation.PushAsync(new ListaProveedorPage());
        }

    }
    private async void btnListadoProveedor_click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaProveedorPage());
    }
}