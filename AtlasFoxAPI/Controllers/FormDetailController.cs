using AtlasFoxAPI.DTO;
using AtlasFoxAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtlasFoxAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormDetailController : ControllerBase
    {

        private readonly _DbContext _context;

        public FormDetailController(_DbContext context)
        {
            _context = context;
        }

        [HttpGet("{formId}")]
        public IActionResult GetFormPPKById(String formId)
        {
            string decodedValue = Uri.UnescapeDataString(formId);
            var formDetail = _context.FormDetail
                .Where(fd => fd.form_id == decodedValue);
            if (formDetail == null)
            {
                return NotFound();
            }
            return Ok(formDetail);
        }
        [HttpGet]
        public IActionResult GetFormDetails()
        {
            var formPPKs = _context.FormDetail.ToList();
            return Ok(formPPKs);
        }
        [HttpPost]
        public IActionResult CreateFormDetail([FromBody] FormDetailDto formDetailDto)
        {
            if (formDetailDto == null)
            {
                return BadRequest("Invalid data received");
            }

            var formDetail = new FormDetail
            {
                form_id = formDetailDto.form_id,
                jumlah = formDetailDto.jumlah,
                satuan = formDetailDto.satuan,
                spesifikasi = formDetailDto.spesifikasi,
                uraian = formDetailDto.uraian
            };

            _context.FormDetail.Add(formDetail);
            _context.SaveChanges();

            return Ok("Form Detail created successfully");
        }
    }
}
