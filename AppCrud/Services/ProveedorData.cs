using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class ProveedorData
    {
        private SQLiteAsyncConnection _conexionBD;

        public ProveedorData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Proveedor>> ListaProveedor()
        {
            var lista = _conexionBD.Table<Proveedor>().ToListAsync();
            return lista;
        }
        public Task<Proveedor> ObtenProveedor(string nombreProveedor, string telefonoProveedor)
        {
            var proveedor = _conexionBD
                .Table<Proveedor>()
                .Where(x => x.NombreProveedor == nombreProveedor && x.TelefonoProveedor == telefonoProveedor)
                .FirstOrDefaultAsync();
            return proveedor;
        }
        public Task<Proveedor> ObtenProveedor(Guid idproveedor)
        {
            var proveedor = _conexionBD
                .Table<Proveedor>()
                .Where(x => x.IdProveedor == idproveedor)
                .FirstOrDefaultAsync();
            return proveedor;
        }
        public async Task<int> GuardarProveedor(Proveedor proveedor)
        {
            var proveedorGuardado = await ObtenProveedor(proveedor.IdProveedor);

            if (proveedorGuardado == null)
            {
                return await _conexionBD.InsertAsync(proveedor);
            }
            else
            {
                return await _conexionBD.UpdateAsync(proveedor);
            }
        }
        public async Task<int> BorrarProveedor(Guid idproveedor)
        { 
                  var proveedor = await _conexionBD.Table<Proveedor>().FirstOrDefaultAsync(p => p.IdProveedor == idproveedor);
            if (proveedor != null)
        {
            return await _conexionBD.DeleteAsync(proveedor);
    }
        return 0; 

    }
}
}

