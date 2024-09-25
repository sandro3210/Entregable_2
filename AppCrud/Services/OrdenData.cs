using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class OrdenData
    {
        private SQLiteAsyncConnection _conexionBD;

        public OrdenData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Orden>> ListaOrden()
        {
            var lista = _conexionBD.Table<Orden>().ToListAsync();
            return lista;
        }
        public Task<Orden> ObtenOrden(string fechaOrden, string productOrdenId)
        {
            var orden = _conexionBD
                .Table<Orden>()
                .Where(x => x.FechaOrden == fechaOrden && x.ProductOrdenID == productOrdenId )
                .FirstOrDefaultAsync();
            return orden;
        }
        public Task<Orden> ObtenOrden(Guid idorden)
        {
            var producto = _conexionBD
                .Table<Orden>()
                .Where(x => x.IdOrden == idorden)
                .FirstOrDefaultAsync();
            return producto;
        }
        public async Task<int> GuardarOrden(Orden orden)
        {
            var ordenGuardado = await ObtenOrden(orden.IdOrden);

            if (ordenGuardado == null)
            {
                return await _conexionBD.InsertAsync(orden);
            }
            else
            {
                return await _conexionBD.UpdateAsync(orden);
            }
        }
        public async Task<int> BorrarOrden(Guid idorden)
        {

            var orden = await _conexionBD.Table<Orden>().FirstOrDefaultAsync(p => p.IdOrden == idorden);
            if (orden != null)
            {
                return await _conexionBD.DeleteAsync(orden);
            }

            return 0;
        }
    }
}
