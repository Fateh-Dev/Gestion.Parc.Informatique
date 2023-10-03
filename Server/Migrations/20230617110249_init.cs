using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PermissionName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Users",
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
                    table.PrimaryKey("PK__Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                });

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
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AppName = table.Column<string>(type: "TEXT", nullable: true),
                    StructureId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ParentStructureId = table.Column<Guid>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    Ordre = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermissionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermissionName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK__RolePermissions__Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "_Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__RolePermissions__Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__UserRoles__Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__UserRoles__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DisplayFr = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayAr = table.Column<string>(type: "TEXT", nullable: true),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Reference = table.Column<string>(type: "TEXT", nullable: true),
                    MarqueId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarqueDisplay = table.Column<string>(type: "TEXT", nullable: true),
                    ModelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModelDisplay = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryDisplay = table.Column<string>(type: "TEXT", nullable: true),
                    TypeConsommation = table.Column<int>(type: "INTEGER", nullable: false),
                    Etat = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReformeDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ActualPositionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ActualPositionDisplay = table.Column<string>(type: "TEXT", nullable: true),
                    OldPositionId = table.Column<Guid>(type: "TEXT", nullable: true),
                    OldPositionDisplay = table.Column<string>(type: "TEXT", nullable: true),
                    Observation = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    MesurmentUnite = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimeUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipements_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipements_Marques_MarqueId",
                        column: x => x.MarqueId,
                        principalTable: "Marques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipements_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipements_Structures_ActualPositionId",
                        column: x => x.ActualPositionId,
                        principalTable: "Structures",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("151d8b53-1fa5-4708-b024-f46594cfd1f9"), "Category 1", null, "Category 1", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("5a63a93b-c46c-4ed6-86a5-630aed3b6b6a"), "Category 4", null, "Category 4", 4 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("640e56dc-8e93-4efd-8e2a-c049699ff3fc"), "Category 3", null, "Category 3", 3 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("81baa055-4b3b-479b-ae62-08ad5e2eff5c"), "Category 2", null, "Category 2", 2 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("a8c8e6bf-6483-483f-bcf0-1fb455fa4c87"), "Category 5", null, "Category 5", 5 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("2b78c7ca-ccab-4b13-8a48-f228415b6545"), "DELL", null, "DELL", 4 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("54c58f23-fd24-4868-89a6-785fb0928b9b"), "ACER", null, "ACER", 2 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("5e1a63e0-1a1e-4214-98ef-167cf9b75b6a"), "FUJITSU", null, "FUJITSU", 3 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("634a44da-f4a6-4577-825f-662b65c00e99"), "HP", null, "HP", 1 });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("7c5eac5e-884b-4074-ab1b-71cc75821131"), "TOSHIBA", null, "TOSHIBA", 5 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("1d109863-ef74-47e1-9f91-9d0e9e768345"), "Model 4", null, "Model 4", 4 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("5b5da82f-7d33-4e07-a2b2-d4cc1d47f221"), "Model 3", null, "Model 3", 3 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("78b76535-d7ef-4c0a-aaf5-b2f487884c3f"), "Model 5", null, "Model 5", 5 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("b6c55dbe-ae51-4238-a458-e3eb8b5bd3f9"), "Model 2", null, "Model 2", 2 });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Description", "DisplayAr", "DisplayFr", "Order" },
                values: new object[] { new Guid("ea2e0863-7eee-472f-a978-bd3ad8fc9fa8"), "Model 1", null, "Model 1", 1 });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("2ea47b50-f16f-4a8a-819e-2efbab498a07"), 1, new DateTime(2023, 6, 17, 11, 2, 49, 4, DateTimeKind.Utc).AddTicks(6936), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("5191217b-fa7c-4967-9672-afa0e0d7ba7d"), 32, new DateTime(2023, 6, 17, 11, 2, 49, 4, DateTimeKind.Utc).AddTicks(7082), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("8c2149a4-ceba-43c1-97b0-f9cc53ffa240"), 30, new DateTime(2023, 6, 17, 11, 2, 49, 4, DateTimeKind.Utc).AddTicks(7088), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.InsertData(
                table: "_Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[] { 1, "Djawed", "Djehinet", "$2a$11$4HvPAEP.KKlCG/N6AsvwcOoJHJiOYf2azHBInCHeqbB5YwDy6/y1C", "Djawed" });

            migrationBuilder.CreateIndex(
                name: "IX__RolePermissions_PermissionId",
                table: "_RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX__RolePermissions_RoleId",
                table: "_RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX__UserRoles_RoleId",
                table: "_UserRoles",
                column: "RoleId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_RolePermissions");

            migrationBuilder.DropTable(
                name: "_UserLogins");

            migrationBuilder.DropTable(
                name: "_UserRoles");

            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "_Permissions");

            migrationBuilder.DropTable(
                name: "_Roles");

            migrationBuilder.DropTable(
                name: "_Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Marques");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Structures");
        }
    }
}
