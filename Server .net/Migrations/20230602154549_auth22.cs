using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    public partial class auth22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionId",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("0c9a0159-7ad3-4a0a-8a6a-a2a22d39ede4"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("446da2be-1881-41d5-8e13-14b8c87ee96d"));

            migrationBuilder.DeleteData(
                table: "Personnes",
                keyColumn: "Id",
                keyValue: new Guid("84438212-670d-4d6d-a3d6-2ecec941e14b"));

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "_Users");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "_UserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "_UserLogins");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "_Roles");

            migrationBuilder.RenameTable(
                name: "RolePermissions",
                newName: "_RolePermissions");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "_Permissions");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "_UserRoles",
                newName: "IX__UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermissions_RoleId",
                table: "_RolePermissions",
                newName: "IX__RolePermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "_RolePermissions",
                newName: "IX__RolePermissions_PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users",
                table: "_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__UserRoles",
                table: "_UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__UserLogins",
                table: "_UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Roles",
                table: "_Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__RolePermissions",
                table: "_RolePermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Permissions",
                table: "_Permissions",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK__RolePermissions__Permissions_PermissionId",
                table: "_RolePermissions",
                column: "PermissionId",
                principalTable: "_Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__RolePermissions__Roles_RoleId",
                table: "_RolePermissions",
                column: "RoleId",
                principalTable: "_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UserRoles__Roles_RoleId",
                table: "_UserRoles",
                column: "RoleId",
                principalTable: "_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UserRoles__Users_UserId",
                table: "_UserRoles",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__RolePermissions__Permissions_PermissionId",
                table: "_RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK__RolePermissions__Roles_RoleId",
                table: "_RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK__UserRoles__Roles_RoleId",
                table: "_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK__UserRoles__Users_UserId",
                table: "_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users",
                table: "_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__UserRoles",
                table: "_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__UserLogins",
                table: "_UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Roles",
                table: "_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__RolePermissions",
                table: "_RolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Permissions",
                table: "_Permissions");

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

            migrationBuilder.RenameTable(
                name: "_Users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "_UserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "_UserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "_Roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "_RolePermissions",
                newName: "RolePermissions");

            migrationBuilder.RenameTable(
                name: "_Permissions",
                newName: "Permissions");

            migrationBuilder.RenameIndex(
                name: "IX__UserRoles_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX__RolePermissions_RoleId",
                table: "RolePermissions",
                newName: "IX_RolePermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX__RolePermissions_PermissionId",
                table: "RolePermissions",
                newName: "IX_RolePermissions_PermissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("0c9a0159-7ad3-4a0a-8a6a-a2a22d39ede4"), 1, new DateTime(2023, 6, 2, 15, 42, 47, 550, DateTimeKind.Utc).AddTicks(7287), null, false, "Djehinet", 0, "Djawed" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("446da2be-1881-41d5-8e13-14b8c87ee96d"), 32, new DateTime(2023, 6, 2, 15, 42, 47, 550, DateTimeKind.Utc).AddTicks(7344), null, false, "Djehinet", 0, "Nadjib" });

            migrationBuilder.InsertData(
                table: "Personnes",
                columns: new[] { "Id", "Age", "CreationTimeUtc", "ExtraProperties", "IsDeleted", "Nom", "Order", "Prenom" },
                values: new object[] { new Guid("84438212-670d-4d6d-a3d6-2ecec941e14b"), 30, new DateTime(2023, 6, 2, 15, 42, 47, 550, DateTimeKind.Utc).AddTicks(7375), null, false, "Djehinet", 0, "Fateh" });

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
