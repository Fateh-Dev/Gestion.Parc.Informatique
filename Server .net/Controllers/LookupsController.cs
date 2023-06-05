using AutoMapper;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Parc.Informatique.Controllers;


[Authorize]
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "Gestion Parc Informatique")]
public class LookupsController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISharedDataService _sharedData;
    private readonly IMapper _mapper;
    private readonly ISharedFunctionService _sharedFunc;
    public LookupsController(AppDbContext context, IMapper mapper, ISharedDataService sharedData, ISharedFunctionService sharedFunc)
    {
        _context = context;
        _sharedData = sharedData;
        _sharedFunc = sharedFunc;
        _mapper = mapper;
    }

    [HttpGet("LoadLookups")]
    public async Task<ActionResult> LoadLookups()
    {
        await _sharedData.LoadLookups();
        return Ok(new { message = "Lookups Loaded Successfully" });
    }
    [HttpGet("GetSettings")]
    [Authorize]
    public async Task<ActionResult<Dictionary<string, SettingsReturnDto>>> GetSettingsFromLookUps()
    {
        var p = _sharedData.GetSettingsDico();
        if (p == null) return NotFound();
        return Ok(p);
    }
    [HttpGet("GetSettingsByApp/{appName}")]
    public async Task<ActionResult<SettingsReturnDto>> GetSettingsByappNameFromLookUps(string appName)
    {
        var p = _sharedData.GetSettingsById(appName);
        if (p == null) return NotFound();
        return Ok(p);
    }
}


