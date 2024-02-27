﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240227083426_OneToOneRelationshipStudent_StudentDetails")]
    partial class OneToOneRelationshipStudent_StudentDetails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            StudentId = new Guid("0227457f-5744-4561-9ca3-6391d43f2433"),
                            Age = 30,
                            IsRegularStudent = false,
                            Name = "John Doe"
                        },
                        new
                        {
                            StudentId = new Guid("e707eb5e-d1b9-4916-a9bd-fa2a40295926"),
                            Age = 25,
                            IsRegularStudent = false,
                            Name = "John Depp"
                        },
                        new
                        {
                            StudentId = new Guid("2b08a39d-267c-4067-bfe4-fd08211eb0b9"),
                            Age = 29,
                            IsRegularStudent = false,
                            Name = "Mike Miles"
                        },
                        new
                        {
                            StudentId = new Guid("e5bbe607-d0df-46a2-aa8c-67a1a3044498"),
                            Age = 100,
                            IsRegularStudent = false,
                            Name = "TEST Name"
                        });
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentDetailsId");

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("Entities.StudentDetails", b =>
                {
                    b.HasOne("Entities.Student", "Student")
                        .WithOne("StudentDetails")
                        .HasForeignKey("Entities.StudentDetails", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.Student", b =>
                {
                    b.Navigation("StudentDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}