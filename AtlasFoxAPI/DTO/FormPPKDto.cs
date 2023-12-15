using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AtlasFoxAPI.DTO
{
    public class FormPPKDto
    {
        [Key]
        [Column("form_id")]
        public String form_id { get; set; }

        [Column("nama_kebutuhan")]
        public String? nama_kebutuhan { get; set; }

        [Column("jenis_kebutuhan")]
        public int? jenis_kebutuhan { get; set; }

        [Column("detail_jenis_kebutuhan")]
        public String? detail_jenis_kebutuhan { get; set; }

        [Column("tanggal_permintaan")]
        public DateTime? tanggal_permintaan { get; set; }

        [Column("tanggal_pembelian")]
        public DateTime? tanggal_pembelian { get; set; }

        [Column("user_id")]
        public String? user_id { get; set; }

        [Column("nama_karyawan")]
        public String? nama_karyawan { get; set; }

        [Column("departement_karyawan")]
        public String? departement_karyawan { get; set; }

        [Column("jabatan_karyawan")]
        public String? jabatan_karyawan { get; set; }

        [Column("nik_manager")]
        public String? nik_manager { get; set; }
    }

}
