using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud
{
    public static class Constants
    {
        private const string BDFileName = "datos.db3";

        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;
        public static string DatabasePath
        {
            get
            {
                return Path
                    .Combine(FileSystem.AppDataDirectory, BDFileName);
            }
        }
    }

}
