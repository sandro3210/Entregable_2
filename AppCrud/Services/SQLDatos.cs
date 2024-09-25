using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class SQLDatos
    {
        readonly SQLiteAsyncConnection _conexionBD;
        public UserData UsuarioDataTable { get; set; }

        public ProductData ProductDataTable { get; set; }

        public ProveedorData ProveedorDataTable { get; set; }

        public CategoriaData CategoriaDataTable { get; set; }

        public OrdenData OrdenDataTable { get; set; }
        public SQLDatos(string path)
        {
            _conexionBD = new SQLiteAsyncConnection(path);

            _conexionBD.CreateTableAsync<Usuario>().Wait();

            _conexionBD.CreateTableAsync<Producto>().Wait(); 

            _conexionBD.CreateTableAsync<Proveedor>().Wait();

            _conexionBD.CreateTableAsync<Categoria>().Wait();

            _conexionBD.CreateTableAsync<Orden>().Wait();

            UsuarioDataTable = new UserData(_conexionBD);

            ProductDataTable = new ProductData(_conexionBD);

            ProveedorDataTable = new ProveedorData(_conexionBD);

            CategoriaDataTable = new CategoriaData(_conexionBD);
            
            OrdenDataTable = new OrdenData(_conexionBD);
        }

    }
}
