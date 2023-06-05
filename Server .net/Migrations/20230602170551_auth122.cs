using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class auth122 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PermissionName",
                table: "_RolePermissions",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("b2f787c1-2bef-4164-9cbe-f8cacb621cde"), 30, new DateTime(2023, 6, 2, 17, 5, 51, 153, DateTimeKind.Utc).AddTicks(2721), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("d03656a7-a37d-46a1-89c3-646eede6abba"), 32, new DateTime(2023, 6, 2, 17, 5, 51, 153, DateTimeKind.Utc).AddTicks(2706), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("d08cf4c4-b8e6-473b-8c85-30b164997cb0"), 1, new DateTime(2023, 6, 2, 17, 5, 51, 153, DateTimeKind.Utc).AddTicks(2672), null, false, "Djehinet", 0, "Djawed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("b2f787c1-2bef-4164-9cbe-f8cacb621cde"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("d03656a7-a37d-46a1-89c3-646eede6abba"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("d08cf4c4-b8e6-473b-8c85-30b164997cb0"));

            migrationBuilder.AlterColumn<int>(
                name: "PermissionName",
                table: "_RolePermissions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

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
    }
}
