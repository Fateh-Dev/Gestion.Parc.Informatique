namespace Gestion.Parc.Informatique.Data;

public class SettingsCreateDto
{
    public string? AppName { get; set; }
    public Guid? StructureId { get; set; }
    public string? Description { get; set; }
    public int? UserId { get; set; }
}
public class SettingsReturnDto
{
    public Guid Id { get; set; }
    public Guid? StructureId { get; set; }
    public string? Description { get; set; }
    public string AppName { get; set; }
    public List<Guid> StructureChildren { get; set; }
}

