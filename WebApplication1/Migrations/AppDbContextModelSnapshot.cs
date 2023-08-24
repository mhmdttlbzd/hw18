﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Context;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LessonStudent", b =>
                {
                    b.Property<int>("Lessonsid")
                        .HasColumnType("int");

                    b.Property<int>("Studentsid")
                        .HasColumnType("int");

                    b.HasKey("Lessonsid", "Studentsid");

                    b.HasIndex("Studentsid");

                    b.ToTable("LessonStudent");
                });

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("WebApplication1.Models.Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("WebApplication1.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("WebApplication1.Models.State", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("WebApplication1.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("StateId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LessonStudent", b =>
                {
                    b.HasOne("WebApplication1.Models.Lesson", null)
                        .WithMany()
                        .HasForeignKey("Lessonsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("Studentsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Address", b =>
                {
                    b.HasOne("WebApplication1.Models.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("WebApplication1.Models.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApplication1.Models.Lesson", b =>
                {
                    b.HasOne("WebApplication1.Models.Professor", "Professor")
                        .WithMany("Lessons")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("WebApplication1.Models.Student", b =>
                {
                    b.HasOne("WebApplication1.Models.State", "State")
                        .WithMany("Students")
                        .HasForeignKey("StateId");

                    b.Navigation("State");
                });

            modelBuilder.Entity("WebApplication1.Models.Professor", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("WebApplication1.Models.State", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("WebApplication1.Models.Student", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
