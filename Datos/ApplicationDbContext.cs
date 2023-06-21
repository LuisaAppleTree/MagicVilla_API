using MagicVilla_API.Modelo;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<NumeroVilla> NumeroVillas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Francesa",
                    Detalle = "Villa con viñedos en Touluse",
                    ImagenUrl = "",
                    Ocupantes = 12,
                    MetrosCuadrados = 70,
                    Tarifa = 500,
                    Amenidad = "Equitación, cata de vinos",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                  new Villa()
                  {
                      Id = 2,
                      Nombre = "Villa Mediterranea",
                      Detalle = "Villa con vista al cristalino mar",
                      ImagenUrl = "",
                      Ocupantes = 8,
                      MetrosCuadrados = 40,
                      Tarifa = 800,
                      Amenidad = "Nado en aguas heladas, bajo el cálido sol de la costa",
                      FechaCreacion = DateTime.Now,
                      FechaActualizacion = DateTime.Now
                  }
            );
        }
    }
}
