namespace Gestion.Parc.Informatique.Data;
public class Marque
{
    public Guid Id { get; set; }
    public string? DisplayFr { get; set; }
    public string? DisplayAr { get; set; }
    public int? Order { get; set; }
    public string? Description { get; set; }
}