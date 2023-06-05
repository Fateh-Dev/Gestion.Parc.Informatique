namespace Gestion.Parc.Informatique.Data;

public class Equipement : EntityBase
{
    public string? DisplayFr { get; set; }
    public string? DisplayAr { get; set; }
    public string? SerialNumber { get; set; } // Can BE Without Serial Nummber
    public string? Reference { get; set; }
    public Guid? MarqueId { get; set; }
    public string? MarqueDisplay { get; set; }
    public Guid? ModelId { get; set; }
    public string? ModelDisplay { get; set; }
    public Guid? CategoryId { get; set; }  //  Ordinateur | Imprimante | Unite Centrale ...etc
    public string? CategoryDisplay { get; set; }  //  Ordinateur | Imprimante | Unite Centrale ...etc
    public TypesConsommation TypeConsommation { get; set; }  //  Consommable | Non Consommable
    public Etats Etat { get; set; } = Etats.Undefined;
    public Status Status { get; set; } = Status.undefined;
    public string? Description { get; set; }
    public DateTime? ReformeDate { get; set; } // Updated When Mise En Reforme
    public Guid? ActualPositionId { get; set; }   // TO DO LATER
    public string? ActualPositionDisplay { get; set; }   // TO DO LATER
    public Guid? OldPositionId { get; set; }   // TO DO LATER
    public string? OldPositionDisplay { get; set; }   // TO DO LATER
    public string? Observation { get; set; }
    public string? Color { get; set; }
    public string? MesurmentUnite { get; set; }  // From DataBase

}
