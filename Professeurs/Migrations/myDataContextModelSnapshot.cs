﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Professeurs.Models;

namespace Professeurs.Migrations
{
    [DbContext(typeof(myDataContext))]
    partial class myDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Professeurs.Models.Etudiant", b =>
                {
                    b.Property<int>("apogee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("academie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("annee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("annee_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("code_promo")
                        .HasColumnType("int");

                    b.Property<DateTime>("ddn")
                        .HasColumnType("datetime2");

                    b.Property<string>("delegation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diplome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ecole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("father_job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("father_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filiere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname_fr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname_fr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ldn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lycee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("massar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mention_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mother_job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mother_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("natio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parents_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_bac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("validated")
                        .HasColumnType("int");

                    b.Property<string>("ville_diplome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("apogee");

                    b.ToTable("etudiants");
                });
#pragma warning restore 612, 618
        }
    }
}
