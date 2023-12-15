using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtlasFoxAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "FormPPK",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nik_manager",
                table: "FormPPK",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "FormDetail",
                columns: table => new
                {
                    rowid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    form_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uraian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jumlah = table.Column<int>(type: "int", nullable: true),
                    satuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spesifikasi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDetail", x => x.rowid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormDetail");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "FormPPK",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nik_manager",
                table: "FormPPK",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
