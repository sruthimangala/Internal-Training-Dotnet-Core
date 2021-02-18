﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineCoursePortal.Data;

namespace OnlineCoursePortal.Migrations
{
    [DbContext(typeof(OnlineCoursePortalContext))]
    [Migration("20210218061102_InitialUpdate")]
    partial class InitialUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("OnlineCoursePortal.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseCredits")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.StudentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("int");

                    b.Property<int>("RegisterNo")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Faculty", b =>
                {
                    b.HasOne("OnlineCoursePortal.Models.Course", "Course")
                        .WithOne("Faculty")
                        .HasForeignKey("OnlineCoursePortal.Models.Faculty", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Student", b =>
                {
                    b.HasOne("OnlineCoursePortal.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.StudentDetails", b =>
                {
                    b.HasOne("OnlineCoursePortal.Models.Student", "Student")
                        .WithOne("Details")
                        .HasForeignKey("OnlineCoursePortal.Models.StudentDetails", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Course", b =>
                {
                    b.Navigation("Faculty");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("OnlineCoursePortal.Models.Student", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
