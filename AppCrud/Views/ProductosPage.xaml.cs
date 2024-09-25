using AppCrud.Models;

namespace AppCrud.Views;

public partial class ProductosPage : ContentPage
{
    Producto _producto;

    public ProductosPage()
    {
        InitializeComponent();
        _producto = new Producto();
        this.BindingContext = _producto;
    }
    private async void btnGuardarProducto_click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_producto.NombreProducto) &&
           string.IsNullOrWhiteSpace(_producto.CantidadProducto) &&
           string.IsNullOrWhiteSpace(_producto.PrecioProducto))
        {
            await DisplayAlert("alerta", "no se permiten campos vacios", "ok");
            return;
        }
        var guardar = await App.BaseDatos.ProductDataTable.GuardarProducto(_producto);
        if (guardar > 0)
        {
            Navigation.PushAsync(new ListaProductosPage());
        }

    }
    private async void btnListadoProductos_click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaProductosPage());
    }
}