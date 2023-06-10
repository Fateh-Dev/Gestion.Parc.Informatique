namespace Gestion.Parc.Informatique.Service;
using AutoMapper;
using Gestion.Parc.Informatique.Data;
using LinqKit;
using Microsoft.EntityFrameworkCore;
public interface IEquipementService
{
    List<Equipement> GetAllEquipements();
    Task<PagedResultDto<Equipement>> GetPagedEquipementsByFliter(PagedEquipementFilter filter);
    EquipementReturnDto GetEquipementById(Guid Id);
    void CreateEquipement(EquipementCreateDto Item);
    void UpdateEquipement(Equipement Item);
    void DeleteEquipementById(Guid Id);

}

public class EquipementService : IEquipementService
{
    private AppDbContext _context;
    private readonly IMapper _mapper;

    public EquipementService(
        AppDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<Equipement> GetAllEquipements()
    {
        throw new NotImplementedException();
    }

    public async Task<PagedResultDto<Equipement>> GetPagedEquipementsByFliter(PagedEquipementFilter filter)
    {
        var result = new PagedResultDto<Equipement>();
        // Calculate the skip count based on the page and pageSize
        int skip = filter.Page * filter.PageSize;

        var retquery = _context.Equipements.AsQueryable();
        // Start with a true predicate
        var predicate = PredicateBuilder.New<Equipement>(true);
        // Continue Building Predicates one by one 
        if (!String.IsNullOrEmpty(filter.DisplayFr))
        {
            predicate = predicate.And(k => (k.DisplayFr.ToUpper()).Contains(filter.DisplayFr.ToUpper()));
        }
        if (!String.IsNullOrEmpty(filter.SerialNumber))
        {
            predicate = predicate.And(k => (k.SerialNumber.ToUpper()).Contains(filter.SerialNumber.ToUpper()));
        }
        if (!String.IsNullOrEmpty(filter.Reference))
        {
            predicate = predicate.And(k => (k.Reference.ToUpper()).Contains(filter.Reference.ToUpper()));
        }
        if (filter.MarqueId.HasValue)
        {
            predicate = predicate.And(k => k.MarqueId == filter.MarqueId);
        }
        if (filter.ModelId.HasValue)
        {
            predicate = predicate.And(k => k.ModelId == filter.ModelId);
        }
        if (filter.CategoryId.HasValue)
        {
            predicate = predicate.And(k => k.CategoryId == filter.CategoryId);
        }
        if (filter.TypeConsommation != TypesConsommation.Undefined)
        {
            predicate = predicate.And(k => k.TypeConsommation == filter.TypeConsommation);
        }
        if (filter.Etat != Etats.Undefined)
        {
            predicate = predicate.And(k => k.Etat == filter.Etat);
        }
        if (filter.Status != Status.Undefined)
        {
            predicate = predicate.And(k => k.Status == filter.Status);
        }
        if (filter.ActualPositionId.HasValue)
        {
            // TODO Get Stucture children
            predicate = predicate.And(k => k.Etat == filter.Etat);
        }
        // if (someCondition)
        // {
        //     predicate = predicate.And(x => x.SomeProperty == someValue);
        // }

        // Retrieve the subset of data based on the skip count and pageSize
        var subsetOfData = await retquery.Where(predicate).ToListAsync(); ;
        result.Items = subsetOfData.Skip(skip).Take(filter.PageSize).ToList();
        result.TotalCount = subsetOfData.Count();
        return result;
    }

    public EquipementReturnDto GetEquipementById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public void CreateEquipement(EquipementCreateDto Item)
    {
        throw new NotImplementedException();
    }

    public void UpdateEquipement(Equipement Item)
    {
        throw new NotImplementedException();
    }

    public void DeleteEquipementById(Guid Id)
    {
        throw new NotImplementedException();
    }
}