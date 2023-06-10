using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class addFroeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ModelId",
                table: "Equipements",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MarqueId",
                table: "Equipements",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Equipements",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_ActualPositionId",
                table: "Equipements",
                column: "ActualPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_CategoryId",
                table: "Equipements",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_MarqueId",
                table: "Equipements",
                column: "MarqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_ModelId",
                table: "Equipements",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipements_Categories_CategoryId",
                table: "Equipements",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipements_Marques_MarqueId",
                table: "Equipements",
                column: "MarqueId",
                principalTable: "Marques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipements_Models_ModelId",
                table: "Equipements",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipements_Structures_ActualPositionId",
                table: "Equipements",
                column: "ActualPositionId",
                principalTable: "Structures",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipements_Categories_CategoryId",
                table: "Equipements");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipements_Marques_MarqueId",
                table: "Equipements");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipements_Models_ModelId",
                table: "Equipements");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipements_Structures_ActualPositionId",
                table: "Equipements");

            migrationBuilder.DropIndex(
                name: "IX_Equipements_ActualPositionId",
                table: "Equipements");

            migrationBuilder.DropIndex(
                name: "IX_Equipements_CategoryId",
                table: "Equipements");

            migrationBuilder.DropIndex(
                name: "IX_Equipements_MarqueId",
                table: "Equipements");

            migrationBuilder.DropIndex(
                name: "IX_Equipements_ModelId",
                table: "Equipements");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ModelId",
                table: "Equipements",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "MarqueId",
                table: "Equipements",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Equipements",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

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
    }
}
