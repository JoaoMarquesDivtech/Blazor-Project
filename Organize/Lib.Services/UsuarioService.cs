using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Data;
using Lib.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lib.Services
{
    public class UsuarioService
    {

        private AplicationDbContext aplicationDbContext;

        public UsuarioService()
        {
            aplicationDbContext = new AplicationDbContext();
        }

        public List<Usuario> ConsultarTodos()
        {
            var usuarios = aplicationDbContext.Usuarios.ToList();
            if (usuarios == null)
                return new List<Usuario>();

            return usuarios;
        }

        public Usuario Consultar(int id)
        {
            var usuario = aplicationDbContext.Usuarios.Where(tb => tb.Id == id).FirstOrDefault();

            if(usuario!=null)
                return usuario;

            return new Usuario();
        }

        public void  Adicionar(Usuario usuario)
        {
            usuario.Id = 0;
            aplicationDbContext.Usuarios.Add(usuario);
            aplicationDbContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var usuario = Consultar(id);

            if (usuario != null) {
                aplicationDbContext.Usuarios.Remove(usuario);
                aplicationDbContext.SaveChanges();
            }
        }
    }
}
