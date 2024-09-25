using AppCrud.Models;
namespace AppCrud.Views;

public partial class ListaProveedorPage : ContentPage
{
	public ListaProveedorPage()
	{
        InitializeComponent();
        Actualizar();

    }
    private async void Actualizar()
    {
        ListaProveedor.ItemsSource = await App.BaseDatos.ProveedorDataTable.ListaProveedor();
    }
    private async void btnVolver_click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void btnEliminarProveedor_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        var idProveedor = (Guid)button.CommandParameter;



        bool confirm = await DisplayAlert("Confirmación", "¿Seguro que deseas eliminar este Proveedor?", "Sí", "No");
        if (confirm)
        {

            await App.BaseDatos.ProveedorDataTable.BorrarProveedor(idProveedor);


            Actualizar();
        }
    }
}