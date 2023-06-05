namespace Gestion.Parc.Informatique.Data;

public class StrcutureCreateDto
{
    public string? DisplayFr { get; set; }
    public string? DisplayAr { get; set; }
    public string? Description { get; set; }
    public Guid? ParentStructureId { get; set; }
}
public class StructureReturnDto
{
    public Guid Id { get; set; }
    public string? DisplayFr { get; set; }
    public Guid? ParentStructureId { get; set; }
}
public class StructureWithChildrenDto
{
    public Guid Id { get; set; }
    public string? DisplayFr { get; set; }
    public List<Guid> StructureChildren { get; set; }

}
