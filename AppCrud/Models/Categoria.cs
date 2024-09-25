using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Models
{
    public class Categoria
    {
        [PrimaryKey]
        public Guid IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
       


        public Categoria()
        {
            IdCategoria = Guid.NewGuid();
        }
    }
}
