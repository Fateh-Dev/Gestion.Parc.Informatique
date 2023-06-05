using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class addattr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "_Permissions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("c21994aa-351a-4cae-b062-77236f29c0f4"), 1, new DateTime(2023, 6, 4, 17, 55, 5, 308, DateTimeKind.Utc).AddTicks(7164), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("c26a48c0-4888-4d15-aa16-70d3fb8a8280"), 32, new DateTime(2023, 6, 4, 17, 55, 5, 308, DateTimeKind.Utc).AddTicks(7213), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("c3dc8e1a-128c-4127-bb02-210b16c11c16"), 30, new DateTime(2023, 6, 4, 17, 55, 5, 308, DateTimeKind.Utc).AddTicks(7217), null, false, "Djehinet", 0, "Fateh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("c21994aa-351a-4cae-b062-77236f29c0f4"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("c26a48c0-4888-4d15-aa16-70d3fb8a8280"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("c3dc8e1a-128c-4127-bb02-210b16c11c16"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "_Permissions");

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
    }
}
