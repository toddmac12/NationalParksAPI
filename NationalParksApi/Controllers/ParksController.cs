using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParksApi.Models;

namespace NationalParksApi.Controllers

  
  {
        [Route("api/[controller]")]
      [ApiController]
      public class ParksController : ControllerBase
      {
          private readonly NationalParksApiContext _db;
  
          public ParksController(NationalParksApiContext db)
          {
              _db = db;
          }

// Create : api/Parks

          [HttpPost]
          public async Task<ActionResult<Park>> Post([FromBody]Park park)
          {
              _db.Parks.Add(park);
              await _db.SaveChangesAsync();
              return CreatedAtAction(nameof(GetParks), new { id = park.ParkId }, park);
          }
// Read : api/Parks/
          [HttpGet]
          public async Task<ActionResult<IEnumerable<Park>>> GetParks()
          {
              return await _db.Parks.ToListAsync();
          }

// Update : api/Parks/

          [HttpPut]
          public async Task<ActionResult<Park>> Put([FromBody]Park park)
          {
              _db.Entry(park).State = EntityState.Modified;
              await _db.SaveChangesAsync();
              return CreatedAtAction(nameof(GetParks), new { id = park.ParkId }, park);
          }
// Delete : api/Parks/

          [HttpDelete("{id}")]
          public async Task<IActionResult> Delete(int id)
          {
              var park = await _db.Parks.FindAsync(id);
              if (park == null)
              {
                  return NotFound();
              }
              _db.Parks.Remove(park);
              await _db.SaveChangesAsync();
              return NoContent();
          }

  
  }
}



