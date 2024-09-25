using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Models
{
    public class Producto
    {
        [PrimaryKey]
        public Guid IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string CantidadProducto { get; set; }
        public string PrecioProducto { get; set; }


        public Producto()
        {
            IdProducto = Guid.NewGuid();
        }
    }
}
