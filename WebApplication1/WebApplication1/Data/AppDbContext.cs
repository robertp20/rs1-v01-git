using Microsoft.EntityFrameworkCore;

using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Studenti => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Ime = "Ana",
                    Prezime = "Anic",
                    BrojIndeksa = "IB260001",
                    DatumRodjenja = new DateOnly(2005, 3, 14),
                    DatumKreiranja = new DateTime(2026, 10, 28)
                },
                 new Student()
                 {
                     Id = 2,
                     Ime = "Edin",
                     Prezime = "Edic",
                     BrojIndeksa = "IB260002",
                     DatumRodjenja = new DateOnly(2005, 3, 14),
                     DatumKreiranja = new DateTime(2026, 10, 28)
                 }

                );
        }
    }
}