using System.ComponentModel.DataAnnotations.Schema;

namespace AtlasFoxAPI.DTO
{
    public class FormDetailDto
    {
        [Column("form_id")]
        public String form_id { get; set; }
        [Column("uraian")]
        public String? uraian { get; set; }
        [Column("jumlah")]
        public int? jumlah { get; set; }
        [Column("satuan")]
        public String? satuan { get; set; }
        [Column("spesifikasi")]
        public String? spesifikasi { get; set; }
    }
}
