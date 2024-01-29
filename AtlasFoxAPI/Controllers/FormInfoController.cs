using AtlasFoxAPI.DTO;
using AtlasFoxAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using System.Net;

namespace AtlasFoxAPI.Controllers
{
    [ApiController]
    [Route("Form/[controller]")]
    public class FormInfoController : ControllerBase
    {
        private readonly _DbContext _dbContext;

        public FormInfoController(_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpDelete("DELETE/{form_id}")]
        public IActionResult deleteForm(String form_id)
        {
            string decodedValue = Uri.UnescapeDataString(form_id);
            var form = _dbContext.FormInfo.Find(decodedValue);
            if(form == null)
            {
                return NotFound();
            }
            _dbContext.FormInfo.Remove(form);
            _dbContext.SaveChanges();
            return Ok(form);

        }
        [HttpGet]
        public IActionResult GetAllFormInfo()
        {
            var formInfo = _dbContext.FormInfo.ToList();
            return Ok(formInfo);
        }
        [HttpGet("ID/{month}")]
        public IActionResult GetIDByMonth(String month)
        {
            DateTime currentDate = DateTime.Parse(Uri.UnescapeDataString(month));
            var highestNumber = 0;
            var formInfo = _dbContext.FormInfo.ToList().Where(f => f.form_id_month.Value.Month == currentDate.Month).ToList();
            if (formInfo.Count > 0)
            {
                highestNumber = formInfo
                    .Where(f => f.form_id_month.Value.Month == currentDate.Month && f.form_id_year.Value.Year == currentDate.Year)
                    .Max(f => f.form_id_num);
                return Ok(highestNumber);
            }
            else
            {
                return Ok(highestNumber);
            }
        }

        [HttpGet("ID")]
        public IActionResult GetIDofCurrentMonth()
        {
            String currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            return GetIDByMonth(currentDate);
        }
        [ResponseCache(CacheProfileName = "Default30")]
        [HttpGet("{formId}")]
        public IActionResult GetFormInfoByID(String formId)
        {
            Console.WriteLine(formId);
            string decodedValue = Uri.UnescapeDataString(formId);
            var formPPK = _dbContext.FormInfo.Find(decodedValue);

            if (formPPK == null)
            {
                return NotFound();
            }

            return Ok(formPPK);
        }

        [HttpPost]
        public IActionResult CreateFormInfo([FromBody] FormInfoDto formInfoDto)
        {
            if (formInfoDto == null)
            {
                return BadRequest("Invalid data received");
            }

            var formInfo = new FormInfo
            {
                form_id = formInfoDto.form_id,
                form_id_num = formInfoDto.form_id_num,
                form_id_type = formInfoDto.form_id_type,
                form_id_dept = formInfoDto.form_id_dept,
                form_id_comp = formInfoDto.form_id_comp,
                form_id_month = formInfoDto.form_id_month,
                form_id_year = formInfoDto.form_id_year,
                nama_kebutuhan = formInfoDto.nama_kebutuhan,
                jenis_kebutuhan = formInfoDto.jenis_kebutuhan,
                detail_jenis_kebutuhan = formInfoDto.detail_jenis_kebutuhan,
                tanggal_permintaan = formInfoDto.tanggal_permintaan,
                tanggal_pembelian = formInfoDto.tanggal_pembelian,
                user_id = formInfoDto.user_id,
                nama_karyawan = formInfoDto.nama_karyawan,
                departement_karyawan = formInfoDto.departement_karyawan,
                jabatan_karyawan = formInfoDto.jabatan_karyawan,
                nik_manager = formInfoDto.nik_manager
            };

            _dbContext.FormInfo.Add(formInfo);
            _dbContext.SaveChanges();

            return Ok("FormPPK created successfully");
        }
    }
}
