using apiDomain.Entities;
using apiDomin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRepository.Context
{
    public class TarefaContexto :DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionStrings");
        }
    }
}
