namespace Gestion.Parc.Informatique.Data;

public class Structure : EntityBase
{
    public string? DisplayFr { get; set; }
    public string? DisplayAr { get; set; }
    public string? Description { get; set; }
    public Guid? ParentStructureId { get; set; }
}

