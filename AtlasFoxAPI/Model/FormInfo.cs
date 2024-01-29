using System.ComponentModel.DataAnnotations;

namespace AtlasFoxAPI.Model
{
    public class FormInfo
    {
        [Key]
        public String form_id { get; set; } // Primary key
        public int form_id_num { get; set; }
        public String form_id_type { get; set; }
        public String form_id_dept { get; set; }
        public String form_id_comp { get; set; }
        public DateTime? form_id_month { get; set; }
        public DateTime? form_id_year { get; set; }
        public String? nama_kebutuhan { get; set; }
        public int? jenis_kebutuhan { get; set; }
        public String? detail_jenis_kebutuhan { get; set; }
        public DateTime? tanggal_permintaan { get; set; }
        public DateTime? tanggal_pembelian { get; set; }
        public String user_id { get; set; }
        public String? nama_karyawan { get; set; }
        public String? departement_karyawan { get; set; }
        public String? jabatan_karyawan { get; set; }
        public String nik_manager { get; set; }
    }
}
