using AppCrud.Models;

namespace AppCrud.Views;

public partial class ListaProductosPage : ContentPage
{
	public ListaProductosPage()
	{
		InitializeComponent();
		Actualizar();

    }
	private async void Actualizar()
	{
        ListaProductos.ItemsSource = await App.BaseDatos.ProductDataTable.ListaProducto();
	}
    private async void btnVolver_click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void btnEliminarProducto_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        var idProducto = (Guid)button.CommandParameter;

        
        bool confirm = await DisplayAlert("Confirmación", "¿Seguro que deseas eliminar este producto?", "Sí", "No");
        if (confirm)
        {
            
            await App.BaseDatos.ProductDataTable.BorrarProducto(idProducto);

            
            Actualizar();
        }
    }
}