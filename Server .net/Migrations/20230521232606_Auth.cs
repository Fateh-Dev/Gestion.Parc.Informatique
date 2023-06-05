using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class Auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("10637af4-13c5-4d61-98b1-4108ba656bd6"), 1, new DateTime(2023, 5, 21, 23, 26, 5, 709, DateTimeKind.Utc).AddTicks(1337), null, false, "Djehinet", "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("3441218f-3659-4c4f-a68c-e2a5462bc93b"), 32, new DateTime(2023, 5, 21, 23, 26, 5, 709, DateTimeKind.Utc).AddTicks(1382), null, false, "Djehinet", "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("eddaee88-d262-48d4-9cf0-4244dd417084"), 30, new DateTime(2023, 5, 21, 23, 26, 5, 709, DateTimeKind.Utc).AddTicks(1386), null, false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[] { 1, "djawed", "djehinet", "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK", "djawed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
