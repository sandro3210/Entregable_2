using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Models
{
    public class Proveedor
    {
        [PrimaryKey]

        public Guid IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        


        public Proveedor()
        {
            IdProveedor = Guid.NewGuid();
        }
    }
}
