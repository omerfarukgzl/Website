﻿// <auto-generated />
using System;
using G191210068_Web_Muhasebe.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace G191210068_Web_Muhasebe.Migrations
{
    [DbContext(typeof(MuhasebeDbContext))]
    [Migration("20220119231222_double")]
    partial class @double
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.Cari", b =>
                {
                    b.Property<int>("CariID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<double>("Bakiye")
                        .HasColumnType("double precision");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fax")
                        .HasColumnType("text");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Grup")
                        .HasColumnType("integer");

                    b.Property<string>("Il")
                        .HasColumnType("text");

                    b.Property<string>("Ilçe")
                        .HasColumnType("text");

                    b.Property<string>("PostaKodu")
                        .HasColumnType("text");

                    b.Property<string>("SevkAdresi")
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.Property<double>("ToplamAlacak")
                        .HasColumnType("double precision");

                    b.Property<double>("ToplamBorc")
                        .HasColumnType("double precision");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Yetkili")
                        .HasColumnType("text");

                    b.HasKey("CariID");

                    b.HasIndex("UserId");

                    b.ToTable("Cari");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.CariIslemler", b =>
                {
                    b.Property<int>("CariIslemlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<double>("Alacak")
                        .HasColumnType("double precision");

                    b.Property<double>("Borc")
                        .HasColumnType("double precision");

                    b.Property<int?>("CariId")
                        .HasColumnType("integer");

                    b.Property<string>("EvrakNo")
                        .HasColumnType("text");

                    b.Property<DateTime>("FaturaTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("GenelToplam")
                        .HasColumnType("double precision");

                    b.Property<double>("Odenen")
                        .HasColumnType("double precision");

                    b.Property<TimeSpan>("Saat")
                        .HasColumnType("interval");

                    b.Property<DateTime>("SevkTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("VadeTarihi")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("islemTuru")
                        .HasColumnType("integer");

                    b.Property<int>("odemeSekli")
                        .HasColumnType("integer");

                    b.HasKey("CariIslemlerID");

                    b.HasIndex("CariId");

                    b.ToTable("CariIslemler");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Birim")
                        .HasColumnType("integer");

                    b.Property<double>("BirimFiyat")
                        .HasColumnType("double precision");

                    b.Property<double>("GenelToplam")
                        .HasColumnType("double precision");

                    b.Property<double>("Iskonto")
                        .HasColumnType("double precision");

                    b.Property<int?>("IslemID")
                        .HasColumnType("integer");

                    b.Property<double>("Kdv")
                        .HasColumnType("double precision");

                    b.Property<double>("Miktar")
                        .HasColumnType("double precision");

                    b.Property<decimal>("Toplam")
                        .HasColumnType("numeric");

                    b.Property<string>("UrunAd")
                        .HasColumnType("text");

                    b.Property<int>("iskontoTuru")
                        .HasColumnType("integer");

                    b.Property<int>("kdvDurum")
                        .HasColumnType("integer");

                    b.HasKey("UrunID");

                    b.HasIndex("IslemID");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.Cari", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.CariIslemler", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.Cari", "Cari")
                        .WithMany()
                        .HasForeignKey("CariId");

                    b.Navigation("Cari");
                });

            modelBuilder.Entity("G191210068_Web_Muhasebe.Models.Urun", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.CariIslemler", "CariIslemler")
                        .WithMany()
                        .HasForeignKey("IslemID");

                    b.Navigation("CariIslemler");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("G191210068_Web_Muhasebe.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("G191210068_Web_Muhasebe.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
