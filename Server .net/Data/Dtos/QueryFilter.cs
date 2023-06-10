namespace Gestion.Parc.Informatique.Data;

public class PagedQueryFilter
{
    public int Page { get; set; }
    public int PageSize { get; set; }
}

public class PagedStructureFilter : PagedQueryFilter
{
    public string? Display { get; set; }
    public Guid? ParentStructureId { get; set; }
}

public class PagedEquipementFilter : PagedQueryFilter
{
    public string? DisplayFr { get; set; }
    public string? DisplayAr { get; set; }
    public string? SerialNumber { get; set; } // Can BE Without Serial Nummber
    public string? Reference { get; set; }
    public Guid? MarqueId { get; set; }
    public Guid? ModelId { get; set; }
    public Guid? CategoryId { get; set; }  //  Ordinateur | Imprimante | Unite Centrale ...etc
    public TypesConsommation? TypeConsommation { get; set; }  //  Consommable | Non Consommable
    public Etats? Etat { get; set; }
    public Status? Status { get; set; }
    public string? Description { get; set; }
    public DateTime? ReformeDate { get; set; } // Updated When Mise En Reforme
    public Guid? ActualPositionId { get; set; }   // TO DO LATER  
    public string? Color { get; set; }
    public string? MesurmentUnite { get; set; }  // From DataBase
}

public class PagedResultDto<T>
{
    public int TotalCount { get; set; }
    public List<T> Items { get; set; }
}