using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta Jurasic Park",
                Price = new decimal(69.9),
                Description = "Camiseta Preta Tema Jurasic Park",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/2_no_internet.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Capacete Darth Vader",
                Price = new decimal(129.9),
                Description = "Capacete Preto Tema Star Wars",
                CategoryName = "Acessório",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/3_vader.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "StormTropper",
                Price = new decimal(254.8),
                Description = "Boneco StormTropper - ActionFigure",
                CategoryName = "Brinquedo",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/4_storm_tropper.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Gamer",
                Price = new decimal(29.9),
                Description = "Camiseta Preta Tema Gamer",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/5_100_gamer.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta SpaceX",
                Price = new decimal(59.9),
                Description = "Camiseta Branca Tema SpaceX",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/6_spacex.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camiseta Coffee",
                Price = new decimal(36.9),
                Description = "Camiseta Creme Tema Café",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/7_coffee.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Moletom Cobra Kai",
                Price = new decimal(69.9),
                Description = "Moletom Preto Tema Cobra Kai",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/8_moletom_cobra_kay.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Livro Star Talk - Neil deGrasse Tyson",
                Price = new decimal(129.9),
                Description = "Livro de Ciências Star Talk - Autor: Neil deGrasse Tyson",
                CategoryName = "Livro",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/9_neil.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Milennium Falcon",
                Price = new decimal(89.9),
                Description = "Brinquedo Milennium Falcon Tema Star Wars",
                CategoryName = "Brinquedo",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/10_milennium_falcon.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camiseta Nerd MARS",
                Price = new decimal(34.9),
                Description = "Camiseta Preta Tema Mars",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/11_mars.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Camiseta Linux",
                Price = new decimal(44.9),
                Description = "Camiseta Branca Tema Linux",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/12_gnu_linux.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Camiseta Dragon Ball",
                Price = new decimal(27.9),
                Description = "Camiseta Branca Tema Dragon Ball Z",
                CategoryName = "Roupa",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/13_dragon_ball.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Adesivo NASA",
                Price = new decimal(19.9),
                Description = "Patch Tema NASA",
                CategoryName = "Acessório",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/14_patch_nasa.jpg"
            });
        }
    }
}
