using AutoMapper;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Service;
using LinqKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Parc.Informatique.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(GroupName = "Gestion Parc Informatique")]
public class StructuresController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISharedDataService _sharedData;
    private readonly IMapper _mapper;
    private readonly ISharedFunctionService _sharedFunc;

    public StructuresController(AppDbContext context, IMapper mapper, ISharedDataService sharedData, ISharedFunctionService sharedFunc)
    {
        _context = context;
        _sharedData = sharedData;
        _sharedFunc = sharedFunc;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<StructureReturnDto>>> Get()
    {
        var p = await _context.Structures.ToListAsync();
        if (p == null) return NotFound();
        return Ok(_mapper.Map<List<StructureWithChildrenDto>>(p));
    }
    [HttpPost]
    public IActionResult createStructure(StrcutureCreateDto s)
    {
        Structure S = _mapper.Map<Structure>(s);
        S.Id = Guid.NewGuid();
        _context.Structures.Add(S);
        _context.SaveChanges();
        return Ok();
    }
    [HttpGet("GetStructureByIdWithChildren")]
    public async Task<ActionResult<StructureWithChildrenDto>> GetStructureByIdWithChildren(Guid IdStructure)
    {
        var strcutures = await _context.Structures.ToListAsync();
        var p = await _context.Structures.FirstOrDefaultAsync(o => o.Id == IdStructure);
        if (p == null) return NotFound();
        StructureWithChildrenDto St = _mapper.Map<StructureWithChildrenDto>(p);
        St.StructureChildren = _sharedFunc.GetAllRecursiveRecords(strcutures, St.Id).Select(o => o.Id).ToList();
        return Ok(St);
    }

    [HttpPost("GetPagedByFilter")]
    public async Task<ActionResult<PagedResultDto<StructureReturnDto>>> GetItems([FromBody] PagedStructureFilter query)
    {
        var result = new PagedResultDto<StructureReturnDto>();
        // Calculate the skip count based on the page and pageSize
        int skip = query.Page * query.PageSize;

        var retquery = _context.Structures.AsQueryable();
        // Start with a true predicate
        var predicate = PredicateBuilder.New<Structure>(true);
        // Continue Building Predicates one by one 
        if (!String.IsNullOrEmpty(query.Display))
        {
            predicate = predicate.And(k => (k.DisplayFr.ToUpper()).Contains(query.Display.ToUpper()));
        }
        // if (someCondition)
        // {
        //     predicate = predicate.And(x => x.SomeProperty == someValue);
        // }

        // Retrieve the subset of data based on the skip count and pageSize
        var subsetOfData = await retquery.Where(predicate).ToListAsync(); ;
        result.Items = _mapper.Map<List<StructureReturnDto>>(subsetOfData.Skip(skip).Take(query.PageSize).ToList());
        result.TotalCount = subsetOfData.Count();
        return Ok(result);
    }

    [HttpGet("loadFromFile")]
    public async Task LoadFromFile()
    {
        await _sharedData.LoadDataFromJsonFile();
    }

}