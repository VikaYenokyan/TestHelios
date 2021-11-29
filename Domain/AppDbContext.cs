using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;



namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ApartmentEntity> Apartments { get; set; }
        public DbSet<BuilderEntity> Builder { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }
        public DbSet<CustomerEntity> Customer { get; set; }
        public DbSet<GKEntity> GK { get; set; }
        public DbSet<RealtorEntity> Realtor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail="MY@EMAIL.COM",
                EmailConfirmed=true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp=string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                UserId = "3b62472e-4f66-49fa-e7685b9565d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageApartmentsArenda",
                Title = "Аренда"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("62b0e406-4f09-4f43-bc49-b8d56a28561e"),
                CodeWord = "PageApartmentsBuy",
                Title = "Продажа"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c70469be-503a-4408-846a-34d1dd5fd6b4"),
                CodeWord = "PageApartment",
                Title = "Апартаменты"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1c0274ec-cb11-4f2a-a941-d2a965d203d0"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("265f2404-234a-4b56-9beb-52ad7b536cf0"),
                CodeWord = "PageMyAccount",
                Title = "Личный кабинет"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("2228e103-1e18-45c6-ac72-eedde501bb6e"),
                CodeWord = "PageForCall",
                Title = "Оставить заявку"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("f2ad343a-532d-48c8-991e-56002c29ea78"),
                CodeWord = "PageGK",
                Title = "Жилые комплексы"
            });
        }
    }
}
