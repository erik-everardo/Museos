using Microsoft.EntityFrameworkCore;
using System.IO;
using Museos.Tablas;

namespace Museos
{
    class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appDir = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\MuseosEQ3";
            Directory.CreateDirectory(appDir);
            optionsBuilder.UseSqlite(@$"Data Source={appDir}\base_de_datos.db;Cache=Shared");
        }
         
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<ComentarioMuseo> ComentariosMuseos { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<UsuarioAdmin> UsuariosAdmin { get; set; } 
        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Museo> Museos { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
    }
}
