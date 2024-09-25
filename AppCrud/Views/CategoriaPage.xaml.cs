using AppCrud.Models;

namespace AppCrud.Views;

public partial class CategoriaPage : ContentPage
{
    Categoria _categoria;

    public CategoriaPage()
    {
        InitializeComponent();
        _categoria = new Categoria();
        this.BindingContext = _categoria;
    }
    private async void btnGuardarCategoria_click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_categoria.NombreCategoria) &&
           string.IsNullOrWhiteSpace(_categoria.DescripcionCategoria))
        {
            await DisplayAlert("alerta", "no se permiten campos vacios", "ok");
            return;
        }
        var guardar = await App.BaseDatos.CategoriaDataTable.GuardarCategoria(_categoria);
        if (guardar > 0)
        {
            Navigation.PushAsync(new ListaCategoriaPage());
        }

    }
    private async void btnListadoCategoria_click(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaCategoriaPage());
    }
}