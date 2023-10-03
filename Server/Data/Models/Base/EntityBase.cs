using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion.Parc.Informatique.Data;
public abstract class EntityBase : IEntityBase
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreationTimeUtc { get; set; } = DateTime.UtcNow;
    public string? ExtraProperties { get; set; }
    public int Order { get; set; }
}
