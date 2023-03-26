﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230326224930_deneme2")]
    partial class deneme2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("About_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("About_Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bussines", b =>
                {
                    b.Property<int>("Bussines_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bussines_Id");

                    b.ToTable("Bussinesses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("Contact_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Contact_Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Job_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_Id");

                    b.HasIndex("Job_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Highliht", b =>
                {
                    b.Property<int>("Highlihts_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Highlihts_Id");

                    b.ToTable("Highlihts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Job", b =>
                {
                    b.Property<int>("Job_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img_Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Job_Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Employee", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Job", "job")
                        .WithMany("Employees")
                        .HasForeignKey("Job_Id");

                    b.Navigation("job");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Job", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
