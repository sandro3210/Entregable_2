namespace AppCrud.Views;

public partial class HomePage : TabbedPage
{
	public HomePage()
	{
		InitializeComponent();

		var pagina1 = new ProductosPage()
		{
			Title = "productos",
			IconImageSource = ""
		};
        var pagina2 = new ProveedorPage()
        {
            Title = "provedor",
            IconImageSource = ""
        };
        var pagina3 = new CategoriaPage()
        {
            Title = "categoria",
            IconImageSource = ""
        };
        var pagina4 = new OrdenPage()
        {
            Title = "orden",
            IconImageSource = ""
        };
        this.Children.Add( pagina1 );
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
        this.Children.Add(pagina4);
    }
}