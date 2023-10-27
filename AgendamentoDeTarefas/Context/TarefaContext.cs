using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using AgendamentoDeTarefas.Entities;

namespace AgendamentoDeTarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions options)  : base(options) 
        { 
        }

        public DbSet<Tarefa>Tarefas {  get; set; }

    }
}
