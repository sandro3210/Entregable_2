namespace AppCrud.Views;

public partial class ListaCategoriaPage : ContentPage
{
    public ListaCategoriaPage()
    {
        InitializeComponent();
        Actualizar();

    }
    private async void Actualizar()
    {
        ListaCategoria.ItemsSource = await App.BaseDatos.CategoriaDataTable.ListaCategoria();
    }
    private async void btnVolver_click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void btnEliminarCategoria_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        var idOrden = (Guid)button.CommandParameter;


        bool confirm = await DisplayAlert("Confirmación", "¿Seguro que deseas eliminar este categoria?", "Sí", "No");
        if (confirm)
        {

            await App.BaseDatos.CategoriaDataTable.BorrarCategoria(idOrden);


            Actualizar();
        }
    }
}
