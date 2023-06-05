using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Parc.Informatique.Controllers;

[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "Gestion Parc Informatique")]
public class PersonnesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISharedDataService _sharedData;

    public PersonnesController(AppDbContext context, ISharedDataService sharedData)
    {
        _context = context;
        _sharedData = sharedData;
    }

    // [HttpGet]
    // public async Task<ActionResult<List<Personne>>> Get()
    // {
    //     var p = await _context.Personnes.ToListAsync();
    //     if (p == null) return NotFound();
    //     return Ok(p);
    // }
    // [HttpGet("{id}")]
    // public async Task<ActionResult<Personne>> GetById(Guid Id)
    // {
    //     var p = await _context.Personnes.FirstOrDefaultAsync(o => o.Id == Id);
    //     if (p == null) return NotFound();
    //     return Ok(p);
    // }
    // [HttpDelete("{id}")]
    // public async Task<ActionResult<Personne>> DeleteById(Guid Id)
    // {
    //     var p = await _context.Personnes.FirstOrDefaultAsync(o => o.Id == Id);
    //     if (p == null) return NotFound();
    //     _context.Remove(p);
    //     await _context.SaveChangesAsync();
    //     return Ok(p);
    // }
}