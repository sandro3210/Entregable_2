using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Models
{
    public class Usuario
    {   
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
