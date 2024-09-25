using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class CategoriaData
    {
        private SQLiteAsyncConnection _conexionBD;

        public CategoriaData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Categoria>> ListaCategoria()
        {
            var lista = _conexionBD.Table<Categoria>().ToListAsync();
            return lista;
        }
        public Task<Categoria> ObtenCategoria(string nombreCategoria, string descripcionCategoria)
        {
            var categoria = _conexionBD
                .Table<Categoria>()
                .Where(x => x.NombreCategoria == nombreCategoria && x.DescripcionCategoria == descripcionCategoria )
                .FirstOrDefaultAsync();
            return categoria;
        }
        public Task<Categoria> ObtenCategoria(Guid idcategoria)
        {
            var categoria = _conexionBD
                .Table<Categoria>()
                .Where(x => x.IdCategoria == idcategoria)
                .FirstOrDefaultAsync();
            return categoria;
        }
        public async Task<int> GuardarCategoria(Categoria categoria)
        {
            var categoriaGuardado = await ObtenCategoria(categoria.IdCategoria);

            if (categoriaGuardado == null)
            {
                return await _conexionBD.InsertAsync(categoria);
            }
            else
            {
                return await _conexionBD.UpdateAsync(categoria);
            }
        }
        public async Task<int> BorrarCategoria(Guid idcategoria)
        {

            var categoria = await _conexionBD.Table<Categoria>().FirstOrDefaultAsync(p => p.IdCategoria == idcategoria);
            if (categoria != null)
            {
                return await _conexionBD.DeleteAsync(categoria);
            }

            return 0;
        }
    }
}
