using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class ProductData
    {
        private SQLiteAsyncConnection _conexionBD;

        public ProductData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Producto>> ListaProducto()
        {
            var lista = _conexionBD.Table<Producto>().ToListAsync();
            return lista;
        }
        public Task<Producto> ObtenProducto(string nombreProducto, string cantidadProducto,string precioProducto)
        {
            var producto = _conexionBD
                .Table<Producto>()
                .Where(x => x.NombreProducto == nombreProducto && x.CantidadProducto == cantidadProducto && x.PrecioProducto == precioProducto)
                .FirstOrDefaultAsync();
            return producto;
        }
        public Task<Producto> ObtenProducto(Guid idproducto)
        {
            var producto = _conexionBD
                .Table<Producto>()
                .Where(x => x.IdProducto == idproducto)
                .FirstOrDefaultAsync();
            return  producto;
        }
        public async Task<int> GuardarProducto(Producto producto)
        {
            var productoGuardado = await ObtenProducto(producto.IdProducto);

            if (productoGuardado == null)
            {
                return await _conexionBD.InsertAsync(producto);
            }
            else
            {
                return await _conexionBD.UpdateAsync(producto);
            }
        }
        public async Task<int> BorrarProducto(Guid idproducto)
        {
            
            var producto = await _conexionBD.Table<Producto>().FirstOrDefaultAsync(p => p.IdProducto == idproducto);
            if (producto != null)
            {
                return await _conexionBD.DeleteAsync(producto);  
            }
                     
            return 0; 
        }

    }
}
