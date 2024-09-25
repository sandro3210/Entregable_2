using AppCrud.Models;
using AppCrud.Services;
using AppCrud.Views;
namespace AppCrud
{
    public partial class App : Application
    {

        static SQLDatos _baseDatos;
        
        public static SQLDatos BaseDatos
        {
            get
            {
                if (_baseDatos == null)
                {
                    _baseDatos =
                        new SQLDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "datos.db3"));
                }
                return _baseDatos;
            }

        }
        public static Usuario Usuario { get; set; }

        public static Producto Producto { get; set; }

        public static Proveedor Proveedor { get; set; }
        
        public static Categoria Categoria { get; set; }
        
        public static Categoria Orden { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
