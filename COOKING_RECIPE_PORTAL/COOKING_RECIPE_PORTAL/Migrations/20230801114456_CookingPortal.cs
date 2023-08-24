using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COOKING_RECIPE_PORTAL.Migrations
{
    /// <inheritdoc />
    public partial class CookingPortal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile_No = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonVeg_Recipe",
                columns: table => new
                {
                    Recipe_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipe_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipe_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonVeg_Recipe", x => x.Recipe_Id);
                });

            migrationBuilder.CreateTable(
                name: "Veg_Recipe",
                columns: table => new
                {
                    Recipe_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipe_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipe_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veg_Recipe", x => x.Recipe_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "NonVeg_Recipe");

            migrationBuilder.DropTable(
                name: "Veg_Recipe");
        }
    }
}
