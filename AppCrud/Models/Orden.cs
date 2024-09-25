using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Models
{
    public class Orden
    {
        [PrimaryKey]

        public Guid IdOrden { get; set; }
        public string FechaOrden { get; set; }
        public string ProductOrdenID { get; set; }



        public Orden()
        {
            IdOrden = Guid.NewGuid();
        }
    }
}
