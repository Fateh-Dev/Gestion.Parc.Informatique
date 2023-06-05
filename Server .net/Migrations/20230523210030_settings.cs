using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class settings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("10637af4-13c5-4d61-98b1-4108ba656bd6"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("3441218f-3659-4c4f-a68c-e2a5462bc93b"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("eddaee88-d262-48d4-9cf0-4244dd417084"));

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AppName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("21952155-edb9-4b81-bf73-6437d1c4d0ea"), 30, new DateTime(2023, 5, 23, 21, 0, 29, 721, DateTimeKind.Utc).AddTicks(850), null, false, "Djehinet", "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("833e8da2-f6e1-42ea-a06f-cbbf7c4b7168"), 32, new DateTime(2023, 5, 23, 21, 0, 29, 721, DateTimeKind.Utc).AddTicks(845), null, false, "Djehinet", "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Prenom" },
                values: new object[] { new Guid("ae1cfdc3-5dbb-41fc-baae-eafeb036c4ca"), 1, new DateTime(2023, 5, 23, 21, 0, 29, 721, DateTimeKind.Utc).AddTicks(800), null, false, "Djehinet", "Djawed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("21952155-edb9-4b81-bf73-6437d1c4d0ea"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("833e8da2-f6e1-42ea-a06f-cbbf7c4b7168"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("ae1cfdc3-5dbb-41fc-baae-eafeb036c4ca"));

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
        }
    }
}
