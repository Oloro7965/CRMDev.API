﻿// <auto-generated />
using System;
using CRMDev.Infraestructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMDev.Infraestructure.Persistance.Migrations
{
    [DbContext(typeof(CRMDevDbContext))]
    [Migration("20240812164638_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FielWorkId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FielWorkId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.FieldWork", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkFields");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Opportunity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Costs")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FailedReason")
                        .HasColumnType("int");

                    b.Property<string>("IncludedSupport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Scope")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Contact", b =>
                {
                    b.HasOne("CRMDev.Core.Domain.Entities.FieldWork", "FieldWork")
                        .WithMany("contacts")
                        .HasForeignKey("FielWorkId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FieldWork");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Note", b =>
                {
                    b.HasOne("CRMDev.Core.Domain.Entities.Contact", "contact")
                        .WithMany("Notes")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("contact");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Opportunity", b =>
                {
                    b.HasOne("CRMDev.Core.Domain.Entities.Contact", "contact")
                        .WithMany("Opportunities")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("contact");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.Contact", b =>
                {
                    b.Navigation("Notes");

                    b.Navigation("Opportunities");
                });

            modelBuilder.Entity("CRMDev.Core.Domain.Entities.FieldWork", b =>
                {
                    b.Navigation("contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
