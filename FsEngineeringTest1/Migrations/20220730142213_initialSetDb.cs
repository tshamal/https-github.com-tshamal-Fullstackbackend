using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FsEngineeringTest1.Migrations
{
    public partial class initialSetDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Jokes",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    icon_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "DateTime", nullable: false),
                    url = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    value = table.Column<string>(type: "NVARCHAR(2500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jokes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    peopleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    height = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    mass = table.Column<double>(type: "float", nullable: false),
                    hair_color = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    skin_color = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    eye_color = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    birth_year = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    gender = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    homeworld = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    edited = table.Column<DateTime>(type: "DateTime", nullable: false),
                    url = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.peopleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Jokes");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
