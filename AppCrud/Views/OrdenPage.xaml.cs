using AppCrud.Models;
namespace AppCrud.Views;

public partial class OrdenPage : ContentPage
{
    Orden _orden;

    public OrdenPage()
    {
        InitializeComponent();
        _orden = new Orden();
        this.BindingContext = _orden;
    }
    private async void btnGuardarOrden_click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_orden.FechaOrden) &&
           string.IsNullOrWhiteSpace(_orden.ProductOrdenID))
        {
            await DisplayAlert("alerta", "no se permiten campos vacios", "ok");
            return;
        }
        var guardar = await App.BaseDatos.OrdenDataTable.GuardarOrden(_orden);
        if (guardar > 0)
        {
            Navigation.PushAsync(new ListaOrdenPage());
        }

    }
    private async void btnListadoOrden_click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaOrdenPage());
    }
}