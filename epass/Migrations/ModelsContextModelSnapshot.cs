﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using epass.models;

namespace epass.Migrations
{
    [DbContext(typeof(ModelsContext))]
    partial class ModelsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("epass.modeles.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Enable")
                        .HasColumnType("boolean");

                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<string>("Indicatif")
                        .HasColumnType("text");

                    b.Property<bool>("Locked")
                        .HasColumnType("boolean");

                    b.Property<string>("Otp")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Stamp")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("epass.modeles.AdminRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("Valeur")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("RoleId");

                    b.ToTable("AdminRole");
                });

            modelBuilder.Entity("epass.modeles.Compte", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Enable")
                        .HasColumnType("boolean");

                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<string>("Indicatif")
                        .HasColumnType("text");

                    b.Property<bool>("Locked")
                        .HasColumnType("boolean");

                    b.Property<string>("Otp")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Stamp")
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Compte");
                });

            modelBuilder.Entity("epass.modeles.Devise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodeIso")
                        .HasColumnType("text");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.Property<string>("Symbole")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Devise");
                });

            modelBuilder.Entity("epass.modeles.EventLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<string>("Event")
                        .HasColumnType("text");

                    b.Property<DateTime>("EventLogDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("EventLog");
                });

            modelBuilder.Entity("epass.modeles.InfoCompte", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Activite")
                        .HasColumnType("text");

                    b.Property<string>("Adresse")
                        .HasColumnType("text");

                    b.Property<string>("Alias")
                        .HasColumnType("text");

                    b.Property<Guid>("CompteId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime>("Naissance")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nationalite")
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<Guid>("PaysId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("PhotoProfil")
                        .HasColumnType("bytea");

                    b.Property<string>("PieceIdentite")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.Property<int>("Sexe")
                        .HasColumnType("integer");

                    b.Property<Guid>("VilleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompteId");

                    b.HasIndex("PaysId");

                    b.HasIndex("VilleId");

                    b.ToTable("InfoCompte");
                });

            modelBuilder.Entity("epass.modeles.Operation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<string>("Destination")
                        .HasColumnType("text");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.Property<decimal>("Montant")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("OperationValeurDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<int>("TypeOperationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("epass.modeles.Paiement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.Property<string>("Pature")
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("epass.modeles.Pays", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodePays")
                        .HasColumnType("text");

                    b.Property<int>("Indicatif")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pays");
                });

            modelBuilder.Entity("epass.modeles.PieceIdentite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PieceIdentite");
                });

            modelBuilder.Entity("epass.modeles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("epass.modeles.TypeOperation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeOperation");
                });

            modelBuilder.Entity("epass.modeles.UserPreference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DeviseId")
                        .HasColumnType("uuid");

                    b.Property<string>("Langue")
                        .HasColumnType("text");

                    b.Property<int>("Pin")
                        .HasColumnType("integer");

                    b.Property<bool>("TouchId")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("DeviseId");

                    b.ToTable("UserPreference");
                });

            modelBuilder.Entity("epass.modeles.Ville", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<Guid>("PaysId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PaysId");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("epass.modeles.AdminRole", b =>
                {
                    b.HasOne("epass.modeles.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epass.modeles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epass.modeles.EventLog", b =>
                {
                    b.HasOne("epass.modeles.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epass.modeles.InfoCompte", b =>
                {
                    b.HasOne("epass.modeles.Compte", "Compte")
                        .WithMany()
                        .HasForeignKey("CompteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epass.modeles.Pays", "Pays")
                        .WithMany()
                        .HasForeignKey("PaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epass.modeles.Ville", "Ville")
                        .WithMany()
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epass.modeles.Operation", b =>
                {
                    b.HasOne("epass.modeles.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epass.modeles.UserPreference", b =>
                {
                    b.HasOne("epass.modeles.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("epass.modeles.Devise", "Devise")
                        .WithMany()
                        .HasForeignKey("DeviseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("epass.modeles.Ville", b =>
                {
                    b.HasOne("epass.modeles.Pays", "Pays")
                        .WithMany("Ville")
                        .HasForeignKey("PaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}