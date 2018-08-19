using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Name = table.Column<string>(maxLength: 60, nullable: false),
                    Product_Description = table.Column<string>(maxLength: 120, nullable: false),
                    category_ID = table.Column<int>(nullable: false),
                    Products_Price = table.Column<double>(nullable: false),
                    CategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Category_Name" },
                values: new object[,]
                {
                    { 1, "Book" },
                    { 2, "Sport" },
                    { 3, "Games" },
                    { 4, "Food" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Product_Description", "Product_Name", "Products_Price", "category_ID" },
                values: new object[,]
                {
                    { 1, null, "This ball is perfect to play football", "Ball", 11.5, 2 },
                    { 2, null, "You play as a Gerald from Rivia, the best monster killer.", "The Witcher 3: wild hund", 110.0, 3 },
                    { 3, null, "Traditional italian pizza made from the best ingredients", "Pizza", 25.99, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
