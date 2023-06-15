﻿// <auto-generated />
using System;
using Gestion.Parc.Informatique.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestion.Parc.Informatique.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20230611163928_newData")]
    partial class newData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Equipement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActualPositionDisplay")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ActualPositionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryDisplay")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<int>("Etat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MarqueDisplay")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MarqueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MesurmentUnite")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModelDisplay")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModelId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OldPositionDisplay")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OldPositionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reference")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReformeDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeConsommation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ActualPositionId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MarqueId");

                    b.HasIndex("ModelId");

                    b.ToTable("Equipements");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Marque", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Marques");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b92ccfcc-42d4-4fd4-b059-ae6afd3662e8"),
                            Description = "HP",
                            DisplayFr = "HP",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("7908b1c2-9985-48ac-b12e-2703b7401c3b"),
                            Description = "ACER",
                            DisplayFr = "ACER",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("9d9143c2-c28e-4a27-8eca-7d87247dbaeb"),
                            Description = "FUJITSU",
                            DisplayFr = "FUJITSU",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("d29e5726-3f2d-4c19-8b71-22118b0a691c"),
                            Description = "DELL",
                            DisplayFr = "DELL",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("9b1e9d33-a6ec-43dd-b512-04072592eaae"),
                            Description = "TOSHIBA",
                            DisplayFr = "TOSHIBA",
                            Order = 1
                        });
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Personne", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personnes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30cfeafc-36f0-423c-80fa-dc56cbab84a8"),
                            Age = 1,
                            CreationTimeUtc = new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7904),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Order = 0,
                            Prenom = "Djawed"
                        },
                        new
                        {
                            Id = new Guid("403c90fc-397b-4e07-b44a-fbea4e1c84b1"),
                            Age = 32,
                            CreationTimeUtc = new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7962),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Order = 0,
                            Prenom = "Nadjib"
                        },
                        new
                        {
                            Id = new Guid("ccb6b9ee-1ddb-4ffc-baff-3645a4e35c42"),
                            Age = 30,
                            CreationTimeUtc = new DateTime(2023, 6, 11, 16, 39, 24, 891, DateTimeKind.Utc).AddTicks(7971),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Order = 0,
                            Prenom = "Fateh"
                        });
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Settings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AppName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("StructureId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Structure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ParentStructureId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Structures");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayAr")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayFr")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Ordre")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("_Permissions");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("_Roles");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermissionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("_RolePermissions");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("_Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "djawed",
                            LastName = "djehinet",
                            PasswordHash = "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK",
                            Username = "djawed"
                        });
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("_UserLogins");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("_UserRoles");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Equipement", b =>
                {
                    b.HasOne("Gestion.Parc.Informatique.Data.Structure", "ActualStructureObject")
                        .WithMany("Equipements")
                        .HasForeignKey("ActualPositionId");

                    b.HasOne("Gestion.Parc.Informatique.Data.Category", "CategoryObject")
                        .WithMany("Equipements")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion.Parc.Informatique.Data.Marque", "MarqueObject")
                        .WithMany("Equipements")
                        .HasForeignKey("MarqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion.Parc.Informatique.Data.Model", "ModelObject")
                        .WithMany("Equipements")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActualStructureObject");

                    b.Navigation("CategoryObject");

                    b.Navigation("MarqueObject");

                    b.Navigation("ModelObject");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.RolePermission", b =>
                {
                    b.HasOne("Gestion.Parc.Informatique.Models.Auth.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion.Parc.Informatique.Models.Auth.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.UserRole", b =>
                {
                    b.HasOne("Gestion.Parc.Informatique.Models.Auth.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion.Parc.Informatique.Models.Auth.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Category", b =>
                {
                    b.Navigation("Equipements");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Marque", b =>
                {
                    b.Navigation("Equipements");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Model", b =>
                {
                    b.Navigation("Equipements");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Data.Structure", b =>
                {
                    b.Navigation("Equipements");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.Role", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gestion.Parc.Informatique.Models.Auth.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
