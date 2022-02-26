using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Price = table.Column<double>(type: "float", nullable: false),
                    Product_Count = table.Column<int>(type: "int", nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_MainImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Product_Status = table.Column<bool>(type: "bit", nullable: false),
                    Color_Id = table.Column<int>(type: "int", nullable: false),
                    Size_Id = table.Column<int>(type: "int", nullable: false),
                    Product_discount = table.Column<int>(type: "int", nullable: false),
                    Product_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
