using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museos.Tablas;

namespace Museos
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=base_de_datos.db;Cache=Shared");
        }
         
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<ComentarioMuseo> ComentariosMuseos { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<UsuarioAdmin> UsuariosAdmin { get; set; } 
        public DbSet<Visitante> Visitantes { get; set; }
    }
}
