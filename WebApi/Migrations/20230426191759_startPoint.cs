using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class startPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "Title" },
                values: new object[] { 1, 275m, "Buzdolabı" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "Title" },
                values: new object[] { 2, 250m, "Çamaşır Makinası" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Price", "Title" },
                values: new object[] { 3, 200m, "Bulaşık Makinası" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
