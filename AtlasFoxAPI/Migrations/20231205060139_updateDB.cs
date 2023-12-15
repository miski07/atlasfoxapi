using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtlasFoxAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormPPK",
                columns: table => new
                {
                    form_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nama_kebutuhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jenis_kebutuhan = table.Column<int>(type: "int", nullable: true),
                    detail_jenis_kebutuhan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tanggal_permintaan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tanggal_pembelian = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nama_karyawan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departement_karyawan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jabatan_karyawan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nik_manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPPK", x => x.form_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormPPK");
        }
    }
}
