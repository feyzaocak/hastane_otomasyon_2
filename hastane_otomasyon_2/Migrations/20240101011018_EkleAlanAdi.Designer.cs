﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hastane_otomasyon_2.Data.efCore;

#nullable disable

namespace hastane_otomasyon_2.Migrations
{
    [DbContext(typeof(HastaneContext))]
    [Migration("20240101011018_EkleAlanAdi")]
    partial class EkleAlanAdi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("hastane_otomasyon_2.Data.Entity.Alan", b =>
                {
                    b.Property<int>("AlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlanAdı")
                        .HasColumnType("TEXT");

                    b.HasKey("AlanId");

                    b.ToTable("Alans");
                });

            modelBuilder.Entity("hastane_otomasyon_2.Data.Entity.Doktor", b =>
                {
                    b.Property<int>("DoktorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlanAdı")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoktorAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoktorSoyadi")
                        .HasColumnType("TEXT");

                    b.HasKey("DoktorId");

                    b.ToTable("Doktors");
                });

            modelBuilder.Entity("hastane_otomasyon_2.Data.Entity.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("KullaniciEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("KullaniciSoyadi")
                        .HasColumnType("TEXT");

                    b.Property<string>("KullaniciTelefon")
                        .HasColumnType("TEXT");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("hastane_otomasyon_2.Data.Entity.Randevu", b =>
                {
                    b.Property<int>("RandevuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlanAdı")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AlanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DoktorAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DoktorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RandevuAdi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RandevuTarihi")
                        .HasColumnType("TEXT");

                    b.HasKey("RandevuId");

                    b.ToTable("Randevus");
                });
#pragma warning restore 612, 618
        }
    }
}
