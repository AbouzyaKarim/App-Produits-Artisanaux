using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Artisanaux.Service.ProductAPI.Migrations
{
    public partial class remplirDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "IdProduct", "CategoryName", "ImageURL", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, "Categorie1", "https://artisanaka.blob.core.windows.net/artisana/1.jpg", 15.0, "Product1" },
                    { 2, "Categorie2", "https://artisanaka.blob.core.windows.net/artisana/2.jpg", 65.0, "Product2" },
                    { 3, "Categorie3", "https://artisanaka.blob.core.windows.net/artisana/3.jpg", 45.0, "Product3" },
                    { 4, "Categorie4", "https://artisanaka.blob.core.windows.net/artisana/4.jpg", 20.0, "Product4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 4);
        }
    }
}
