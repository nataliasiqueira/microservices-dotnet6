using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Roupa", "Camiseta Preta Tema Jurasic Park", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/2_no_internet.jpg", "Camiseta Jurasic Park", 69.9m },
                    { 3L, "Acessório", "Capacete Preto Tema Star Wars", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/3_vader.jpg", "Capacete Darth Vader", 129.9m },
                    { 4L, "Brinquedo", "Boneco StormTropper - ActionFigure", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/4_storm_tropper.jpg", "StormTropper", 254.8m },
                    { 5L, "Roupa", "Camiseta Preta Tema Gamer", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/5_100_gamer.jpg", "Camiseta Gamer", 29.9m },
                    { 6L, "Roupa", "Camiseta Branca Tema SpaceX", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/6_spacex.jpg", "Camiseta SpaceX", 59.9m },
                    { 7L, "Roupa", "Camiseta Creme Tema Café", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/7_coffee.jpg", "Camiseta Coffee", 36.9m },
                    { 8L, "Roupa", "Moletom Preto Tema Cobra Kai", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/8_moletom_cobra_kay.jpg", "Moletom Cobra Kai", 69.9m },
                    { 9L, "Livro", "Livro de Ciências Star Talk - Autor: Neil deGrasse Tyson", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/9_neil.jpg", "Livro Star Talk - Neil deGrasse Tyson", 129.9m },
                    { 10L, "Brinquedo", "Brinquedo Milennium Falcon Tema Star Wars", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/10_milennium_falcon.jpg", "Milennium Falcon", 89.9m },
                    { 11L, "Roupa", "Camiseta Preta Tema Mars", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/11_mars.jpg", "Camiseta Nerd MARS", 34.9m },
                    { 12L, "Roupa", "Camiseta Branca Tema Linux", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/12_gnu_linux.jpg", "Camiseta Linux", 44.9m },
                    { 13L, "Roupa", "Camiseta Branca Tema Dragon Ball Z", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/13_dragon_ball.jpg", "Camiseta Dragon Ball", 27.9m },
                    { 14L, "Acessório", "Patch Tema NASA", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/dot_net6_LTS/ShoppingImages/14_patch_nasa.jpg", "Adesivo NASA", 19.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);
        }
    }
}
