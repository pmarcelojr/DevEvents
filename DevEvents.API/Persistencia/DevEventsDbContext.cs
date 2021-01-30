using DevEvents.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevEvents.API.Persistencia
{
    public class DevEventsDbContext : DbContext
    {
        public DevEventsDbContext(DbContextOptions<DevEventsDbContext> options) : base(options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                .ToTable("tb_Evento");

            modelBuilder.Entity<Evento>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Categoria)
                .WithMany()
                .HasForeignKey(e => e.IdCategoria);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.IdUsuario);

            modelBuilder.Entity<Usuario>()
                .ToTable("tb_Usuario");
            
            modelBuilder.Entity<Usuario>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Categoria>()
                .ToTable("tb_Categoria");
            
            modelBuilder.Entity<Categoria>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Inscricao>()
                .ToTable("tb_Inscricao");

            modelBuilder.Entity<Inscricao>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Evento)
                .WithMany(e => e.Inscricoes)
                .HasForeignKey(i => i.IdEvento)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Inscricao>()
                .HasOne(i => i.Usuario)
                .WithMany(e => e.Inscricoes)
                .HasForeignKey(i => i.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}