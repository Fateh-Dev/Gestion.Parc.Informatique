using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("5faa204c-3aee-495a-9ad1-0be85582ea01"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("aed82f2c-655d-4b8f-8860-10b1e7884c4b"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("cebac24b-9d52-4db0-a2d0-6a74a1653e67"));

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("7908b1c2-9985-48ac-b12e-2703b7401c3b"), "ACER", null, "ACER", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("9b1e9d33-a6ec-43dd-b512-04072592eaae"), "TOSHIBA", null, "TOSHIBA", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("9d9143c2-c28e-4a27-8eca-7d87247dbaeb"), "FUJITSU", null, "FUJITSU", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("b92ccfcc-42d4-4fd4-b059-ae6afd3662e8"), "HP", null, "HP", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("d29e5726-3f2d-4c19-8b71-22118b0a691c"), "DELL", null, "DELL", 1 });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("30cfeafc-36f0-423c-80fa-dc56cbab84a8"), 1, new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7904), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("403c90fc-397b-4e07-b44a-fbea4e1c84b1"), 32, new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7962), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("ccb6b9ee-1ddb-4ffc-baff-3645a4e35c42"), 30, new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7971), null, false, "Djehinet", 0, "Fateh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("7908b1c2-9985-48ac-b12e-2703b7401c3b"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("9b1e9d33-a6ec-43dd-b512-04072592eaae"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("9d9143c2-c28e-4a27-8eca-7d87247dbaeb"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("b92ccfcc-42d4-4fd4-b059-ae6afd3662e8"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("d29e5726-3f2d-4c19-8b71-22118b0a691c"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("30cfeafc-36f0-423c-80fa-dc56cbab84a8"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("403c90fc-397b-4e07-b44a-fbea4e1c84b1"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("ccb6b9ee-1ddb-4ffc-baff-3645a4e35c42"));

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5faa204c-3aee-495a-9ad1-0be85582ea01"), 32, new DateTime(2023, 6, 10, 12, 24, 25, 138, DateTimeKind.Utc).AddTicks(57), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("aed82f2c-655d-4b8f-8860-10b1e7884c4b"), 30, new DateTime(2023, 6, 10, 12, 24, 25, 138, DateTimeKind.Utc).AddTicks(61), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("cebac24b-9d52-4db0-a2d0-6a74a1653e67"), 1, new DateTime(2023, 6, 10, 12, 24, 25, 138, DateTimeKind.Utc).AddTicks(7), null, false, "Djehinet", 0, "Djawed" });
        }
    }
}
