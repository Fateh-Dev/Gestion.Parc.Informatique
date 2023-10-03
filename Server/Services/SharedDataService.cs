using Gestion.Parc.Informatique.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Gestion.Parc.Informatique.Service;

public interface ISharedDataService
{
    Dictionary<Guid, StructureReturnDto> GetStrcuturesDico();
    void SetStrcuturesDico(Dictionary<Guid, StructureReturnDto> Dic);

    // --------------------------------------------------------------------
    Dictionary<string, SettingsReturnDto> GetSettingsDico();
    SettingsReturnDto GetSettingsById(string appName);
    void SetSettingsDico(Dictionary<string, SettingsReturnDto> Dic);
    // --------------------------------------------------------------------
    Task LoadLookups();
    Task LoadDataFromJsonFile();
}
public class SharedDataService : ISharedDataService
{
    Dictionary<string, SettingsReturnDto> Settings = new Dictionary<string, SettingsReturnDto>();
    Dictionary<Guid, StructureReturnDto> Structures = new Dictionary<Guid, StructureReturnDto>();
    Dictionary<Guid, Lookup> PersonneDico = new Dictionary<Guid, Lookup>();

    private readonly IServiceScopeFactory _scopeFactory;
    public SharedDataService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public List<Guid> GetAllRecursiveRecords(List<Structure> structures, Guid Id)
    {
        var result = new List<Guid>();
        result.Add(Id);
        // Retrieve the initial records with the specified idparent
        var initialRecords = structures.Where(e => e.ParentStructureId == Id).ToList();

        result.AddRange(initialRecords.Select(o => o.Id));
        // Recursively retrieve child records for each initial record
        foreach (var record in initialRecords)
        {
            result.AddRange(GetAllRecursiveRecords(structures, record.Id));
        }
        return result.Distinct().ToList();
    }
    public async Task LoadLookups()
    {
        Console.Write("--- Loading Data ---> ");
        using (var scope = _scopeFactory.CreateScope())
        {
            // Using Context inside IHosted Service
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            DbSet<Structure> structureDbSet = dbContext.Set<Structure>();
            List<StructureReturnDto> structureLookup = structureDbSet.Where(o => o.IsDeleted == false).Select(t => new StructureReturnDto
            {
                Id = t.Id,
                DisplayFr = t.DisplayFr,
                ParentStructureId = t.ParentStructureId,
            }).ToList();
            SetStrcuturesDico(structureLookup.ToDictionary(l => l.Id));
            var structures = await dbContext.Structures.ToListAsync();
            DbSet<Settings> settingsDbSet = dbContext.Set<Settings>();
            List<SettingsReturnDto> settingsLookup = settingsDbSet
             .Where(o => !o.IsDeleted)
             .Select(t => new
             {
                 t.Id,
                 t.AppName,
                 t.StructureId
             })
             .ToList()
             .Select(t => new SettingsReturnDto
             {
                 Id = t.Id,
                 AppName = t.AppName,
                 StructureId = t.StructureId,
             })
             .ToList();
            var struc = await dbContext.Structures.ToListAsync();
            if (struc != null)
                foreach (var item in settingsLookup)
                {
                    item.StructureChildren = GetAllRecursiveRecords(struc, item.StructureId ?? Guid.Empty);
                }
            SetSettingsDico(settingsLookup.ToDictionary(l => l.AppName));


        }
        Console.WriteLine("Done");
    }
    public SettingsReturnDto GetSettingsById(string appName)
    {
        if (Settings.ContainsKey(appName))
        {
            SettingsReturnDto value = Settings[appName];
            // Use the retrieved value
            Console.WriteLine(value);
            return value;
        }
        else
        {
            // Key does not exist in the dictionary
            Console.WriteLine("Key not found");
            return null;
        }
    }

    public Dictionary<string, SettingsReturnDto> GetSettingsDico()
    {
        return this.Settings;
    }
    public void SetSettingsDico(Dictionary<string, SettingsReturnDto> Dic)
    {
        this.Settings = Dic;
    }

    public Dictionary<Guid, StructureReturnDto> GetStrcuturesDico()
    {
        return this.Structures;
    }

    public void SetStrcuturesDico(Dictionary<Guid, StructureReturnDto> Dic)
    {
        this.Structures = Dic;
    }

    public async Task LoadDataFromJsonFile()
    {
        using (StreamReader r = new StreamReader("Seed Files/Structures.json"))
        {
            string json = r.ReadToEnd();
            List<Structure> structures = JsonConvert.DeserializeObject<List<Structure>>(json);

            using (var scope = _scopeFactory.CreateScope())
            {
                // Using Context inside IHosted Service
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                dbContext.Structures.AddRange(structures);
                await dbContext.SaveChangesAsync();
            }
        }
        using (StreamReader r = new StreamReader("Seed Files/Settings.json"))
        {
            string json = r.ReadToEnd();
            List<Settings> settings = JsonConvert.DeserializeObject<List<Settings>>(json);

            using (var scope = _scopeFactory.CreateScope())
            {
                // Using Context inside IHosted Service
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Settings.AddRange(settings);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}