using emedicalform_server.Data;
using emedicalform_server.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace emedicalform_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patients>>> GetAllData()
        {
            return await _context.Patients.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patients>> GetDataById(int id)
        {
            var findId = await _context.Patients.FindAsync(id);

            if(findId == null)
            {
                return NotFound();
            }

            return findId;
        }

        [HttpPost]
        public async Task<ActionResult<Patients>> PostData(Patients patients)
        {
            _context.Patients.Add(patients);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllData), new { id = patients.Id }, patients);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutData(int id, Patients patients)
        {
            if(id != patients.Id)
            {
                return BadRequest();
            }

            _context.Entry(patients).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Patients>> DeleteData(int id)
        {
            var findId = await _context.Patients.FindAsync(id);
            if(findId == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(findId);
            await _context.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
