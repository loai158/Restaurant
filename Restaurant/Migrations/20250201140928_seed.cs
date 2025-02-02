using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Appitizer" },
                    { 2, "Dessert" },
                    { 3, "Main" },
                    { 4, "Side Dish" },
                    { 5, "Salad" }
                });

            migrationBuilder.InsertData(
                table: "Ingrediants",
                columns: new[] { "IngrediantId", "Name" },
                values: new object[,]
                {
                    { 1, "Chicken" },
                    { 2, "Beef" },
                    { 3, "Fish" },
                    { 4, "Letto" },
                    { 5, "Mooto" },
                    { 6, "Pickels" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CatgoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, null, 3, "Beef Steak Beef Steak", "", "Beef Steak", 150m, 100 },
                    { 2, null, 3, "Chicken wings Chicken wings", "", "Chicken wings", 180m, 120 },
                    { 3, null, 3, "Fish Salamon Fish Salamon", "", "Fish Salamon", 116m, 110 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngrediants",
                columns: new[] { "IngrediantId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngrediants",
                keyColumns: new[] { "IngrediantId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingrediants",
                keyColumn: "IngrediantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
