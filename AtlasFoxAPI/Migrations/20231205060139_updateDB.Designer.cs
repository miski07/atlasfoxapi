﻿// <auto-generated />
using System;
using AtlasFoxAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AtlasFoxAPI.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20231205060139_updateDB")]
    partial class updateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AtlasFoxAPI.Model.FormPPK", b =>
                {
                    b.Property<string>("FormId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("form_id");

                    b.Property<string>("DepartementKaryawan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("departement_karyawan");

                    b.Property<string>("DetailJenisKebutuhan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("detail_jenis_kebutuhan");

                    b.Property<string>("JabatanKaryawan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("jabatan_karyawan");

                    b.Property<int?>("JenisKebutuhan")
                        .HasColumnType("int")
                        .HasColumnName("jenis_kebutuhan");

                    b.Property<string>("NIKManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nik_manager");

                    b.Property<string>("NamaKaryawan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nama_karyawan");

                    b.Property<string>("NamaKebutuhan")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nama_kebutuhan");

                    b.Property<DateTime?>("TanggalPembelian")
                        .HasColumnType("datetime2")
                        .HasColumnName("tanggal_pembelian");

                    b.Property<DateTime?>("TanggalPermintaan")
                        .HasColumnType("datetime2")
                        .HasColumnName("tanggal_permintaan");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_id");

                    b.HasKey("FormId");

                    b.ToTable("FormPPK");
                });
#pragma warning restore 612, 618
        }
    }
}