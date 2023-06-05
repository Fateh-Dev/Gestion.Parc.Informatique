using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class updaeuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("5669c63a-9bac-4928-9019-f9e3d59bfd1f"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("9b7237a9-a500-4819-ae58-e393edfb561e"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("ca5690d9-01e4-4267-b555-7b2f59570380"));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Settings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5669c63a-9bac-4928-9019-f9e3d59bfd1f"), 32, new DateTime(2023, 5, 25, 21, 43, 2, 415, DateTimeKind.Utc).AddTicks(431), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("9b7237a9-a500-4819-ae58-e393edfb561e"), 1, new DateTime(2023, 5, 25, 21, 43, 2, 415, DateTimeKind.Utc).AddTicks(381), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("ca5690d9-01e4-4267-b555-7b2f59570380"), 30, new DateTime(2023, 5, 25, 21, 43, 2, 415, DateTimeKind.Utc).AddTicks(436), null, false, "Djehinet", 0, "Fateh" });
        }
    }
}
