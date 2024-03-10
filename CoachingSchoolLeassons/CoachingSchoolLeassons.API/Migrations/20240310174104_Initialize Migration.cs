using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoachingSchoolLeassons.API.Migrations
{
    /// <inheritdoc />
    public partial class InitializeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayAndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSubjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7742d5ad-776d-4b67-b32b-dc7c57a6a97c"), "Teacher" },
                    { new Guid("7744c786-47c5-439d-8c82-4b4b1109f9a9"), "SuperUser" },
                    { new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10c1905d-00ad-401a-94e1-700350d61e63"), "Mandarin" },
                    { new Guid("20c1905d-00ad-401a-94e1-700350d61e63"), "English" },
                    { new Guid("75c1905d-00ad-401a-94e1-700350d61e63"), "Greek" },
                    { new Guid("77a99d53-5a5f-4d5d-a56e-a8da6dfdff66"), "Dutch" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName", "RoleId" },
                values: new object[,]
                {
                    { new Guid("03c833f5-b1c7-4b4c-b601-0ff89b737090"), "Giorgos", null, "Armadopoulos", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("05042e39-cc2d-4759-9e52-2d970c4ee955"), "Thomas", null, "Preachon", new Guid("7742d5ad-776d-4b67-b32b-dc7c57a6a97c") },
                    { new Guid("0be4c1c5-76ca-4a5e-95b8-13a7578182a2"), "Pete", null, "Luca", new Guid("7742d5ad-776d-4b67-b32b-dc7c57a6a97c") },
                    { new Guid("0ec91ce7-48a1-4b57-8cba-59e6a679b975"), "Maria", null, "Aslanidou", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("3d28154c-a358-4c56-bef1-61bad294be3c"), "Mike", null, "van Oheilly", new Guid("7742d5ad-776d-4b67-b32b-dc7c57a6a97c") },
                    { new Guid("4844084f-a7c4-49bb-adfb-bd7d31b7c828"), "John", null, "Admin", new Guid("7744c786-47c5-439d-8c82-4b4b1109f9a9") },
                    { new Guid("5dccc28e-c1d9-48f4-ab15-57ca98375b60"), "Giannis", null, "Kamperakis", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("6c8c4096-7734-499a-a3cf-bc8b5e6aac0f"), "Kalliroi", null, "Eustratiou", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("93fee0bd-b3b8-4623-b070-957e93f15cd0"), "Ilias", null, "Kazanias", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("b06cdf54-0efe-4e1b-9c8c-95ba57674eec"), "Giorgos", null, "Papadopoulos", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("d2d7c9fc-9e3b-464a-80ff-0bb3b099f4b2"), "Stavros", null, "Iliiadakis", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("da0f197b-5e6f-475c-bb86-a4b46904e76b"), "Loukas", null, "Iliadakis", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("e4b163c2-a785-4525-b18a-b07a66de6aef"), "Aristotelis", null, "Sofianos", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") },
                    { new Guid("f47bc91d-a949-412b-9c28-0ee682dad6c1"), "July", null, "Kennedy", new Guid("7742d5ad-776d-4b67-b32b-dc7c57a6a97c") },
                    { new Guid("f6df939d-20dc-4d20-b85b-7cc98412b1a4"), "Giannis", null, "Loukiadis", new Guid("c39618f0-9cd5-4d68-88e9-5b2ffe924cee") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserSubjects");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
