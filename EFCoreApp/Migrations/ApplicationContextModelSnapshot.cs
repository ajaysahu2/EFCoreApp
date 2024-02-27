﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegularStudent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("41b8d128-696d-41b3-951c-42a59e0bf638"),
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            StudentId = new Guid("c1137e8e-1a55-41a8-91a6-ecb7eacde840"),
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "John Depp"
                        },
                        new
                        {
                            StudentId = new Guid("cc15dc21-9bee-4544-bd47-fe967b3d496e"),
                            Age = 29,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            StudentId = new Guid("cb004594-65d5-45a1-844e-0d7ea020373f"),
                            Age = 100,
                            IsRegularStudent = false,
                            Name = "TEST Name"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
