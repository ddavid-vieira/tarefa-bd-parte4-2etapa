using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tarefa_bd_parte4_2etapa
{
    public class MainDbContext : DbContext
    {
        public virtual DbSet<Cliente> Cliente => Set<Cliente>();

        public virtual DbSet<Categoria> Categoria => Set<Categoria>();

        public virtual DbSet<Projeto> Projeto => Set<Projeto>();

        public virtual DbSet<Equipe> Equipe => Set<Equipe>();

        public virtual DbSet<Tipo> Tipo => Set<Tipo>();

        public virtual DbSet<Status> Status => Set<Status>();

        public virtual DbSet<Tag> Tag => Set<Tag>();

        public virtual DbSet<Tarefa> Tarefa => Set<Tarefa>();

        public virtual DbSet<Usuario> Usuario => Set<Usuario>();

        public virtual DbSet<TarefaUsuarioStatus> TarefaUsuarioStatus => Set<TarefaUsuarioStatus>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(
                    "User ID=postgres;Password=7hELjWbk4mXeM&;Host=database-1.cjl7wuocylmp.us-east-1.rds.amazonaws.com;Port=5432;Database=tarefa-bd;Pooling=true;Connection Lifetime=0;"
                )
                .EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    
    
    }
}
