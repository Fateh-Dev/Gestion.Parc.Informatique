namespace Gestion.Parc.Informatique.Data;
public class Settings : EntityBase
{
    public string? AppName { get; set; }
    public Guid? StructureId { get; set; }
    public string? Description { get; set; }
    public int UserId { get; set; }
}