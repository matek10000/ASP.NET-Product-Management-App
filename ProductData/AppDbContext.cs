using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductData.Entities;
using System;

namespace ProductData
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private string DbPath { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "products.db");
        }

        public AppDbContext()
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tworzenie użytkownika
            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "matek",
                Email = "mateusz@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "MATEUSZ@GMAIL.COM",
                NormalizedUserName = "MATEK"
            };

            // Hashowanie hasła
            var passwordHasher = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "haslo123");

            // Dodanie użytkownika do bazy
            modelBuilder.Entity<IdentityUser>()
                .HasData(user);

            // Tworzenie roli
            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            // Dodanie roli do bazy
            adminRole.ConcurrencyStamp = adminRole.Id;
            modelBuilder.Entity<IdentityRole>()
                .HasData(adminRole);

            // Przypisanie roli do użytkownika
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = adminRole.Id,
                        UserId = user.Id
                    }
                );

            modelBuilder.Entity<ProductEntity>()
                .HasKey(p => p.Id);


            modelBuilder.Entity<ProductEntity>()
                .HasData(
                    new ProductEntity { Id = 1, Name = "Jabłko", Price = 5.0m, Manufacturer = "Polskie Jablko", ProductionDate = DateTime.Now, Description = "Najlepsze polskie jablka!" },
                    new ProductEntity { Id = 2, Name = "Marchewka", Price = 7.0m, Manufacturer = "MarchekoweLove", ProductionDate = DateTime.Now, Description = "Zakochaj sie w marchwi!" },
                    new ProductEntity { Id = 3, Name = "Gruszka", Price = 9.0m, Manufacturer = "GruGruPOL", ProductionDate = DateTime.Now, Description = "Potrzebna mi gotówka - oto twoja gruszka!" },
                    new ProductEntity { Id = 4, Name = "Sałata", Price = 7.5m, Manufacturer = "GreenPoland", ProductionDate = DateTime.Now, Description = "Produkt z GreenPoland" },
                    new ProductEntity { Id = 5, Name = "Kapusta", Price = 7.0m, Manufacturer = "GreenPoland", ProductionDate = DateTime.Now, Description = "Produkt z GreenPoland" },
                    new ProductEntity { Id = 6, Name = "Rukola", Price = 12.0m, Manufacturer = "GreenPoland", ProductionDate = DateTime.Now, Description = "Produkt z GreenPoland" },
                    new ProductEntity { Id = 7, Name = "Orzech włoski", Price = 13.0m, Manufacturer = "Italiano", ProductionDate = DateTime.Now, Description = "Le migliori noci solo con noi!" }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
