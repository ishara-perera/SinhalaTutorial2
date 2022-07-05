using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SinhalaTutorial.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FullName" },
                values: new object[,]
                {
                    { 1, "Ishara Perera" },
                    { 2, "Ashan Nishantha" },
                    { 3, "Suranjith Geeshan" },
                    { 4, "Lahiru Mudalige" },
                    { 5, "Rachitha Wathsala" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2022, 7, 4, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3300), "Learn ASP.NET Sinhala Tutorial", new DateTime(2022, 7, 8, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3315), 0, "ASP.NET" },
                    { 2, 2, new DateTime(2022, 7, 4, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3326), "Learn Python", new DateTime(2022, 7, 8, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3327), 2, "Python" },
                    { 3, 3, new DateTime(2022, 7, 4, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3329), "Learn Angular Tutorial", new DateTime(2022, 7, 8, 19, 8, 30, 835, DateTimeKind.Local).AddTicks(3330), 0, "Angular" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
