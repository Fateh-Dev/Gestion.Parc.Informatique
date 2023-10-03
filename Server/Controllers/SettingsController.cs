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
public class SettingsController : ControllerBase
{

    /* TODO
        Creation d un record Settings :
            - get strcuture Id and retrieve children before saveChanges()
            - Check if there is a record with same AppName And userId
            - 

        Delete un record Settings :
            - 

        Update un record Settings :
    */
    private readonly AppDbContext _context;
    private readonly ISharedDataService _sharedData;
    private readonly IMapper _mapper;
    private readonly ISharedFunctionService _sharedFunc;

    public SettingsController(AppDbContext context, IMapper mapper, ISharedDataService sharedData, ISharedFunctionService sharedFunc)
    {
        _context = context;
        _sharedData = sharedData;
        _sharedFunc = sharedFunc;
        _mapper = mapper;
    }


    [HttpGet("{appName}")]
    public async Task<ActionResult<SettingsReturnDto>> GetById(string appName)
    {
        var ev = await _context.Settings.FirstOrDefaultAsync(o => o.AppName == appName);
        if (ev == null) return NotFound(new { message = "Element Not Found" });
        var structures = await _context.Structures.ToListAsync();
        SettingsReturnDto settings = _mapper.Map<SettingsReturnDto>(ev);
        settings.StructureChildren = _sharedFunc.GetChildrenListIds(structures, settings.StructureId);
        return Ok(settings);
    }

    [HttpDelete("{appName}")]
    public async Task<ActionResult> DeleteById(string appName)
    {
        var p = _context.Settings.FirstOrDefault(o => o.AppName == appName);
        if (p != null)
            _context.Settings.Remove(p);
        await _context.SaveChangesAsync();
        //TODO Change From SharedFunctions
        await _sharedData.LoadLookups();
        return Ok(new { message = "Settings was Successfully Deleted" });
    }

    [HttpPost]
    public async Task<ActionResult> createSetting([FromBody] SettingsCreateDto settings)
    {
        // TODO ADD WHERE Current User
        var ev = _context.Settings.FirstOrDefault(o => o.AppName == settings.AppName);
        if (ev != null) return Ok(new { message = "Existe Déja ...!" });
        var data = _mapper.Map<Settings>(settings);
        data.Id = Guid.NewGuid();
        _context.Settings.Add(data);
        _context.SaveChanges();
        return Ok(data);
    }

    [HttpPut] // TODO LATER
    public ActionResult updateSetting([FromBody] SettingsCreateDto settings)
    {
        var ev = _context.Settings.FirstOrDefault(o => o.AppName == settings.AppName);
        if (ev == null) return NotFound(new { message = "Element Not Found" });
        // TODO Use Auto-Mapper
        Settings set = new Settings()
        {
            Id = Guid.NewGuid(),
            AppName = settings.AppName,
            UserId = 1
        };
        return Ok(settings);
    }
}