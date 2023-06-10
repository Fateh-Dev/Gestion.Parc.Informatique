using AutoMapper;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using LinqKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Parc.Informatique.Controllers;

// [Authorize]
[ApiController]
[Route("[controller]")]
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

    [HttpGet]
    public async Task<ActionResult<List<EquipementReturnDto>>> Get()
    {
        var p = await _context.Equipements.ToListAsync();
        if (p == null) return NotFound();
        return Ok(_mapper.Map<List<EquipementReturnDto>>(p));
    }


    [HttpPost("GetPagedEquipementsByFliter")]
    public async Task<ActionResult<PagedResultDto<EquipementReturnDto>>> GetPagedEquipementsByFliter([FromBody] PagedEquipementFilter query)
    {
        var result = await _equipementService.GetPagedEquipementsByFliter(query);
        return Ok(result);
    }


}