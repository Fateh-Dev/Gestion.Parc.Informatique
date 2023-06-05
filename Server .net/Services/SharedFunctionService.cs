using Gestion.Parc.Informatique.Data;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Parc.Informatique.Service;

public interface ISharedFunctionService
{
    List<Guid> GetChildrenListIds(List<Structure> structures, Guid? Id);
    List<Structure> GetAllRecursiveRecords(List<Structure> structures, Guid? Id);
}
public class SharedFunctionService : ISharedFunctionService
{

    private readonly ISharedDataService _sharedData;

    public SharedFunctionService(ISharedDataService sharedData)
    {
        _sharedData = sharedData;
    }

    public List<Structure> GetAllRecursiveRecords(List<Structure> structures, Guid? Id)
    {
        var result = new List<Structure>();
        // Retrieve the initial records with the specified idparent
        var initialRecords = structures.Where(e => e.ParentStructureId == Id).ToList();

        result.AddRange(initialRecords);
        // Recursively retrieve child records for each initial record
        foreach (var record in initialRecords)
        {
            result.AddRange(GetAllRecursiveRecords(structures, record.Id));
        }


        return result;
    }
    public List<Guid> GetChildrenListIds(List<Structure> structures, Guid? Id)
    {
        var result = GetAllRecursiveRecords(structures, Id).Select(o => o.Id).ToList();
        if (Id != Guid.Empty) result.Add(Id ?? Guid.Empty);
        return result;
    }
}