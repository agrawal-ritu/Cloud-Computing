﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trial3;

namespace NoteApp_Production.Migrations
{
    [DbContext(typeof(CLOUD_CSYEContext))]
    [Migration("20190314090503_DB")]
    partial class DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("trial3.Attachments", b =>
                {
                    b.Property<string>("AID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FileName")
                        .HasColumnName("FileName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("length")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnName("length")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("noteID")
                        .HasColumnName("NoteID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("url")
                        .HasColumnName("URL")
                        .HasColumnType("varchar(250)");

                    b.HasKey("AID");

                    b.HasIndex("noteID")
                        .IsUnique();

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("trial3.NOTES", b =>
                {
                    b.Property<string>("noteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EMAIL")
                        .HasColumnName("EMAIL")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("created_on")
                        .HasColumnName("Created_On")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("last_updated_on")
                        .HasColumnName("Last_Updated_On")
                        .HasColumnType("DateTime");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(100)");

                    b.HasKey("noteID");

                    b.ToTable("NOTES");
                });

            modelBuilder.Entity("trial3.Users", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EMAIL")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Email");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("trial3.Attachments", b =>
                {
                    b.HasOne("trial3.NOTES")
                        .WithOne("attachments")
                        .HasForeignKey("trial3.Attachments", "noteID");
                });
#pragma warning restore 612, 618
        }
    }
}
