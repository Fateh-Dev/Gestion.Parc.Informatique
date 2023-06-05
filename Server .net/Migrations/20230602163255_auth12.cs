using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class auth12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("5fb4b019-d4d6-44b3-8272-d2d3dd5b3cca"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("70dd8908-d725-46b6-b669-9d3ea2803196"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("c08b1c9c-3f6f-4a87-8b29-917ae0f46f83"));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("07dc11a7-a1b7-482b-9ebc-4d079a8a4f39"), 32, new DateTime(2023, 6, 2, 16, 32, 55, 56, DateTimeKind.Utc).AddTicks(6089), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("33cd67f5-3aab-4b50-bab4-619b29ab36ad"), 30, new DateTime(2023, 6, 2, 16, 32, 55, 56, DateTimeKind.Utc).AddTicks(6091), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("fcab0169-6975-4b50-afc2-b98dc73fc595"), 1, new DateTime(2023, 6, 2, 16, 32, 55, 56, DateTimeKind.Utc).AddTicks(6059), null, false, "Djehinet", 0, "Djawed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("07dc11a7-a1b7-482b-9ebc-4d079a8a4f39"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("33cd67f5-3aab-4b50-bab4-619b29ab36ad"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("fcab0169-6975-4b50-afc2-b98dc73fc595"));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5fb4b019-d4d6-44b3-8272-d2d3dd5b3cca"), 30, new DateTime(2023, 6, 2, 15, 45, 49, 145, DateTimeKind.Utc).AddTicks(2754), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("70dd8908-d725-46b6-b669-9d3ea2803196"), 32, new DateTime(2023, 6, 2, 15, 45, 49, 145, DateTimeKind.Utc).AddTicks(2750), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("c08b1c9c-3f6f-4a87-8b29-917ae0f46f83"), 1, new DateTime(2023, 6, 2, 15, 45, 49, 145, DateTimeKind.Utc).AddTicks(2704), null, false, "Djehinet", 0, "Djawed" });
        }
    }
}
