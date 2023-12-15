using AtlasFoxAPI.DTO;
using AtlasFoxAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtlasFoxAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormPPKController : ControllerBase
    {
        private readonly _DbContext _dbContext;

        public FormPPKController(_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllFormPPKs()
        {
            var formPPKs = _dbContext.FormPPK.ToList();
            return Ok(formPPKs);
        }

        [HttpGet("{formId}")]
        public IActionResult GetFormPPKById(String formId)
        {
            Console.WriteLine(formId);
            string decodedValue = Uri.UnescapeDataString(formId);
            var formPPK = _dbContext.FormPPK.Find(decodedValue);

            if (formPPK == null)
            {
                return NotFound();
            }

            return Ok(formPPK);
        }

        [HttpPost]
        public IActionResult CreateFormPPK([FromBody] FormPPKDto formPPKDto)
        {
            if (formPPKDto == null)
            {
                return BadRequest("Invalid data received");
            }

            var formPPK = new FormPPK
            {
                form_id = formPPKDto.form_id,
                nama_kebutuhan = formPPKDto.nama_kebutuhan,
                jenis_kebutuhan = formPPKDto.jenis_kebutuhan,
                detail_jenis_kebutuhan = formPPKDto.detail_jenis_kebutuhan,
                tanggal_permintaan = formPPKDto.tanggal_permintaan,
                tanggal_pembelian = formPPKDto.tanggal_pembelian,
                user_id = formPPKDto.user_id,
                nama_karyawan = formPPKDto.nama_karyawan,
                departement_karyawan = formPPKDto.departement_karyawan,
                jabatan_karyawan = formPPKDto.jabatan_karyawan,
                nik_manager = formPPKDto.nik_manager
            };

            _dbContext.FormPPK.Add(formPPK);
            _dbContext.SaveChanges();

            return Ok("FormPPK created successfully");
        }
        // Add other CRUD actions as needed...
    }

}
