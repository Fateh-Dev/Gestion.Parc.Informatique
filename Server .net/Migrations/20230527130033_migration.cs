using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("87bc59c8-ec01-43f6-aad5-d5e1bc178ef1"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("eb8cde7d-4884-4597-bd60-b89f0c27496d"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("ec314e8d-1fb8-41c1-a8ac-e11b8cab8e04"));

            migrationBuilder.DropColumn(
                name: "StructureChildren",
                table: "Settings");

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5a5511ac-5237-48f5-b54d-034a3e772cac"), 1, new DateTime(2023, 5, 27, 13, 0, 32, 963, DateTimeKind.Utc).AddTicks(7498), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("bdc60ca7-1f3c-4e64-a10c-b4121f74be97"), 32, new DateTime(2023, 5, 27, 13, 0, 32, 963, DateTimeKind.Utc).AddTicks(7548), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("f1a34b3a-c196-4e57-a7d7-812cfb3d898b"), 30, new DateTime(2023, 5, 27, 13, 0, 32, 963, DateTimeKind.Utc).AddTicks(7552), null, false, "Djehinet", 0, "Fateh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("5a5511ac-5237-48f5-b54d-034a3e772cac"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("bdc60ca7-1f3c-4e64-a10c-b4121f74be97"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("f1a34b3a-c196-4e57-a7d7-812cfb3d898b"));

            migrationBuilder.AddColumn<string>(
                name: "StructureChildren",
                table: "Settings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("87bc59c8-ec01-43f6-aad5-d5e1bc178ef1"), 30, new DateTime(2023, 5, 26, 15, 41, 12, 751, DateTimeKind.Utc).AddTicks(6218), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("eb8cde7d-4884-4597-bd60-b89f0c27496d"), 32, new DateTime(2023, 5, 26, 15, 41, 12, 751, DateTimeKind.Utc).AddTicks(6214), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("ec314e8d-1fb8-41c1-a8ac-e11b8cab8e04"), 1, new DateTime(2023, 5, 26, 15, 41, 12, 751, DateTimeKind.Utc).AddTicks(6164), null, false, "Djehinet", 0, "Djawed" });
        }
    }
}
