using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public interface Database
    {
        string SQLiteLocalPath(string basededatos);
    }
}
