using AutoMapper; // Import necessary namespaces
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using LinqKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Apply authorization to all actions in this controller
[Authorize]
[ApiController]
[Route("[controller]")]

// Configure API Explorer settings for this controller
[ApiExplorerSettings(GroupName = "Gestion Parc Informatique")]
public class EquipementController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISharedDataService _sharedData;
    private readonly IEquipementService _equipementService;
    private readonly IMapper _mapper;
    private readonly ISharedFunctionService _sharedFunc;

    public EquipementController(AppDbContext context, IMapper mapper, IEquipementService equipementService, ISharedDataService sharedData, ISharedFunctionService sharedFunc)
    {
        _context = context;
        _sharedData = sharedData;
        _equipementService = equipementService;
        _sharedFunc = sharedFunc;
        _mapper = mapper;
    }

    // Get a list of all equipements
    [HttpGet]
    public async Task<ActionResult<List<EquipementReturnDto>>> Get()
    {
        var p = await _context.Equipements.ToListAsync();
        if (p == null) return NotFound();
        return Ok(_mapper.Map<List<EquipementReturnDto>>(p));
    }

    // Get paged equipements by filter criteria
    [HttpPost("GetPagedEquipementsByFliter")]
    public async Task<ActionResult<PagedResultDto<EquipementReturnDto>>> GetPagedEquipementsByFliter([FromBody] PagedEquipementFilter query)
    {
        var result = await _equipementService.GetPagedEquipementsByFliter(query);
        return Ok(result);
    }

    // Change the order of equipements
    [HttpGet("ChangeOrder")]
    public async Task<ActionResult> ChangeOrder(int oldIndex, int newIndex)
    {
        _equipementService.ChangeMarqueOrder(oldIndex, newIndex);
        return Ok();
    }
}
