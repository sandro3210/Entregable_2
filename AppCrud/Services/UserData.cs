using AppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud.Services
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexionBD;

        public UserData(SQLiteAsyncConnection conexionBD)
        {
            _conexionBD = conexionBD;
        }
        public Task<List<Usuario>> ListaUsuarios()
        {
            var lista = _conexionBD.Table<Usuario>().ToListAsync();
            return lista;
        }
        public Task<Usuario> ObtenUsuario(string username, string contraseña) 
        {
            var usuario = _conexionBD
                .Table<Usuario>()
                .Where(x => x.User == username && x.Contraseña == contraseña)
                .FirstOrDefaultAsync();
            return usuario;
        }
        public Task<Usuario> ObtenUsuario(Guid id)
        {
            var usuario = _conexionBD
                .Table<Usuario>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return usuario;
        }
        public async Task<int> GuardarUsuario(Usuario usuario)
        {
            var usuariogardado = await ObtenUsuario(usuario.Id);

            if (usuariogardado == null)
            {
                return await _conexionBD.InsertAsync(usuario);
            }
            else
            {
                return await _conexionBD.UpdateAsync(usuario);
            }
        }
        public async Task<int> BorrarUsuario(Guid id)
        {
            return await _conexionBD.DeleteAsync(id);
        }
    
    }
}