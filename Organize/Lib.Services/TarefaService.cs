using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Data;
using Lib.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lib.Services
{
    public class TarefaService
    {

        private AplicationDbContext aplicationDbContext;

        public TarefaService()
        {
            aplicationDbContext = new AplicationDbContext();
        }

        public List<Tarefa> ConsultarTodos()
        {
            var tasks = aplicationDbContext.Tarefas.ToList();
            if (tasks == null)
                return new List<Tarefa>();

            return tasks;
        }

        public Data.Entities.Tarefa Consultar(int id)
        {
            var task = aplicationDbContext.Tarefas.Where(tb => tb.Id == id).FirstOrDefault();

            if(task!=null)
                return task;

            return new Tarefa();
        }

        public void  Adicionar(Tarefa usuario)
        {
            usuario.Id = 0;
            aplicationDbContext.Tarefas.Add(usuario);
            aplicationDbContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var usuario = Consultar(id);

            if (usuario != null) {
                aplicationDbContext.Tarefas.Remove(usuario);
                aplicationDbContext.SaveChanges();
            }
        }
    }
}
