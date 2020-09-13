﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiRoutesResponses.Context;

namespace WebApiRoutesResponses.Migrations
{
    [DbContext(typeof(ApiAppContext))]
    [Migration("20200908002506_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiRoutesResponses.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c671f0c2-0bea-4a0e-94e2-4f73c2ce6964"),
                            Active = true,
                            DateCreated = new DateTime(2020, 9, 7, 19, 25, 5, 806, DateTimeKind.Local).AddTicks(4934),
                            LastName = "LastName 1",
                            Name = "User 1"
                        },
                        new
                        {
                            UserId = new Guid("d98b427f-3c1e-41b4-a47c-1b241be73512"),
                            Active = true,
                            DateCreated = new DateTime(2020, 9, 7, 19, 25, 5, 808, DateTimeKind.Local).AddTicks(7213),
                            LastName = "LastName 2",
                            Name = "User 2"
                        },
                        new
                        {
                            UserId = new Guid("89723579-24f8-4314-a4b2-200f2e78c36a"),
                            Active = true,
                            DateCreated = new DateTime(2020, 9, 7, 19, 25, 5, 808, DateTimeKind.Local).AddTicks(7288),
                            LastName = "LastName 3",
                            Name = "User 3"
                        });
                });

            modelBuilder.Entity("WebApiRoutesResponses.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserRoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserRoleId = new Guid("c931445a-c44d-4466-941b-fa6657ddec53"),
                            Active = true,
                            Role = "Admin",
                            UserId = new Guid("c671f0c2-0bea-4a0e-94e2-4f73c2ce6964")
                        },
                        new
                        {
                            UserRoleId = new Guid("6ad598d5-3c59-487b-b7a6-6ce92dc9fdac"),
                            Active = true,
                            Role = "User",
                            UserId = new Guid("c671f0c2-0bea-4a0e-94e2-4f73c2ce6964")
                        },
                        new
                        {
                            UserRoleId = new Guid("093f069f-743d-48e3-81c6-c22352d21ca8"),
                            Active = true,
                            Role = "Support",
                            UserId = new Guid("c671f0c2-0bea-4a0e-94e2-4f73c2ce6964")
                        },
                        new
                        {
                            UserRoleId = new Guid("8ca995b4-2d30-4554-a269-3872ae994c64"),
                            Active = true,
                            Role = "Admin",
                            UserId = new Guid("d98b427f-3c1e-41b4-a47c-1b241be73512")
                        });
                });

            modelBuilder.Entity("WebApiRoutesResponses.Models.UserRole", b =>
                {
                    b.HasOne("WebApiRoutesResponses.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}