﻿// <auto-generated />
using System;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ETicaretContext))]
    [Migration("20220529154605_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklamasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("DataAccess.Entities.KullaniciDetayi", b =>
                {
                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("KullaniciId");

                    b.HasIndex("SehirId");

                    b.HasIndex("UlkeId");

                    b.ToTable("KullaniciDetaylari");
                });

            modelBuilder.Entity("DataAccess.Entities.Magaza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Puani")
                        .HasColumnType("tinyint");

                    b.Property<bool>("SanalMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Magazalar");
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(170)
                        .HasColumnType("nvarchar(170)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("DataAccess.Entities.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(105)
                        .HasColumnType("nvarchar(105)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("DataAccess.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklamasi")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("BirimFiyati")
                        .HasColumnType("float");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SonKullanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("DataAccess.Entities.UrunMagaza", b =>
                {
                    b.Property<int>("UrunId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("MagazaId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("UrunId", "MagazaId");

                    b.HasIndex("MagazaId");

                    b.ToTable("UrunMagazalar");
                });

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.HasOne("DataAccess.Entities.Rol", "Rol")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("DataAccess.Entities.KullaniciDetayi", b =>
                {
                    b.HasOne("DataAccess.Entities.Kullanici", "Kullanici")
                        .WithOne("KullaniciDetayi")
                        .HasForeignKey("DataAccess.Entities.KullaniciDetayi", "KullaniciId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Sehir", "Sehir")
                        .WithMany("KullaniciDetaylari")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Ulke", "Ulke")
                        .WithMany("KullaniciDetaylari")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.HasOne("DataAccess.Entities.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("DataAccess.Entities.Urun", b =>
                {
                    b.HasOne("DataAccess.Entities.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DataAccess.Entities.UrunMagaza", b =>
                {
                    b.HasOne("DataAccess.Entities.Magaza", "Magaza")
                        .WithMany("UrunMagazalar")
                        .HasForeignKey("MagazaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Urun", "Urun")
                        .WithMany("UrunMagazalar")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Magaza");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("DataAccess.Entities.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("DataAccess.Entities.Kullanici", b =>
                {
                    b.Navigation("KullaniciDetayi");
                });

            modelBuilder.Entity("DataAccess.Entities.Magaza", b =>
                {
                    b.Navigation("UrunMagazalar");
                });

            modelBuilder.Entity("DataAccess.Entities.Rol", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("DataAccess.Entities.Sehir", b =>
                {
                    b.Navigation("KullaniciDetaylari");
                });

            modelBuilder.Entity("DataAccess.Entities.Ulke", b =>
                {
                    b.Navigation("KullaniciDetaylari");

                    b.Navigation("Sehirler");
                });

            modelBuilder.Entity("DataAccess.Entities.Urun", b =>
                {
                    b.Navigation("UrunMagazalar");
                });
#pragma warning restore 612, 618
        }
    }
}
