using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class newDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("013f566e-8d30-4d95-8b33-42e4a0b338ae"), "Category 5", null, "Category 5", 5 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("25d247d5-e703-4a50-b745-d9cf8203caae"), "Category 3", null, "Category 3", 3 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("a9264c8e-d4c4-4a32-be52-dbb5393a7a31"), "Category 1", null, "Category 1", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("e47df604-154c-4e58-a50a-de0eca2b3e7b"), "Category 4", null, "Category 4", 4 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("eaeb0684-b0da-428c-8ec5-e42eb028066d"), "Category 2", null, "Category 2", 2 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("72b670f4-e936-4215-8be1-678d5b24ac96"), "FUJITSU", null, "FUJITSU", 3 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("a82bb24b-9215-42f3-88d4-7a1948cff06f"), "TOSHIBA", null, "TOSHIBA", 5 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("b5bd3515-f734-47d5-9b2c-1c28384adb99"), "DELL", null, "DELL", 4 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("b8f149c8-3b26-46ec-bd2d-abbe1424848d"), "HP", null, "HP", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("d14f4b20-7c4a-4da1-8182-317f922849ab"), "ACER", null, "ACER", 2 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("0ebdc9de-9cbe-45eb-a414-ec391605b5ca"), "Model 1", null, "Model 1", 1 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("3dc56ce3-9afb-48f7-86a5-8cb1e52887a3"), "Model 3", null, "Model 3", 3 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("7b655c44-0d3c-46d9-a5a5-37d6f88501b9"), "Model 2", null, "Model 2", 2 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("c557e6cb-ae17-4e20-9044-2798b4c1b8e1"), "Model 5", null, "Model 5", 5 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("d7715320-cd75-4c48-bc0b-31f5bad93cf9"), "Model 4", null, "Model 4", 4 });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("21b7ea8b-4e14-447f-8336-f8b70fcf0ea6"), 1, new DateTime(2023, 6, 11, 16, 48, 23, 204, DateTimeKind.Utc).AddTicks(6802), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5e06237f-aa27-4ef7-8372-a984353aa614"), 30, new DateTime(2023, 6, 11, 16, 48, 23, 204, DateTimeKind.Utc).AddTicks(6865), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("7907c627-624b-490b-9870-5dcea12a61e5"), 32, new DateTime(2023, 6, 11, 16, 48, 23, 204, DateTimeKind.Utc).AddTicks(6860), null, false, "Djehinet", 0, "Nadjib" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("013f566e-8d30-4d95-8b33-42e4a0b338ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("25d247d5-e703-4a50-b745-d9cf8203caae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9264c8e-d4c4-4a32-be52-dbb5393a7a31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e47df604-154c-4e58-a50a-de0eca2b3e7b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaeb0684-b0da-428c-8ec5-e42eb028066d"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("72b670f4-e936-4215-8be1-678d5b24ac96"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("a82bb24b-9215-42f3-88d4-7a1948cff06f"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("b5bd3515-f734-47d5-9b2c-1c28384adb99"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("b8f149c8-3b26-46ec-bd2d-abbe1424848d"));

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: new Guid("d14f4b20-7c4a-4da1-8182-317f922849ab"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("0ebdc9de-9cbe-45eb-a414-ec391605b5ca"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("3dc56ce3-9afb-48f7-86a5-8cb1e52887a3"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("7b655c44-0d3c-46d9-a5a5-37d6f88501b9"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("c557e6cb-ae17-4e20-9044-2798b4c1b8e1"));

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: new Guid("d7715320-cd75-4c48-bc0b-31f5bad93cf9"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("21b7ea8b-4e14-447f-8336-f8b70fcf0ea6"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("5e06237f-aa27-4ef7-8372-a984353aa614"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("7907c627-624b-490b-9870-5dcea12a61e5"));

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
    }
}
