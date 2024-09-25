namespace AppCrud.Views;

public partial class ListaOrdenPage : ContentPage
{
    public ListaOrdenPage()
    {
        InitializeComponent();
        Actualizar();

    }
    private async void Actualizar()
    {
        ListaOrden.ItemsSource = await App.BaseDatos.OrdenDataTable.ListaOrden();
    }
    private async void btnVolver_click(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void btnEliminarOrden_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        var idOrden = (Guid)button.CommandParameter;


        bool confirm = await DisplayAlert("Confirmaci�n", "�Seguro que deseas eliminar este orden?", "S�", "No");
        if (confirm)
        {

            await App.BaseDatos.OrdenDataTable.BorrarOrden(idOrden);


            Actualizar();
        }
    }
}