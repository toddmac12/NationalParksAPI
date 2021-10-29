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
        [Route("api/nationalparks/[controller]")]
      [ApiController]
      public class ParksController : ControllerBase
      {
          private readonly NationalParksApiContext _db;
  
          public ParksController(NationalParksApiContext db)
          {
              _db = db;
          }
         
  
          // GET: api/Parks
          [HttpGet]
          public async Task<ActionResult<IEnumerable<Park>>> GetParks()
          {
              return await _db.Parks.ToListAsync();
          }
  
          // GET: api/Parks/5
          [HttpGet("{id}")]
          public async Task<ActionResult<Park>> GetPark(int id)
          {
              var park = await _db.Parks.FindAsync(id);
  
              if (park == null)
              {
                  return NotFound();
              }
  
              return park;
          }
  
          // PUT: api/Parks/5
          // To protect from overposting attacks, enable the specific properties you want to bind to, for
          // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
          [HttpPut("{id}")]
          public async Task<IActionResult> Put(int id, Park park)
          {
              if (id != park.ParkId)
              {
                  return BadRequest();
              }
  
              _db.Entry(park).State = EntityState.Modified;
  
              try
              {
                  await _db.SaveChangesAsync();
              }
              catch (DbUpdateConcurrencyException)
              {
                  if (ParkExists(id))
                  {
                      return NotFound();
                  }
                  else
                  {
                      throw;
                  }
              }
        
              return NoContent();
          }
      private bool ParkExists(int id)
    {
      return _db.Parks.Any(p => p.ParkId == id);
    }
  }
}



