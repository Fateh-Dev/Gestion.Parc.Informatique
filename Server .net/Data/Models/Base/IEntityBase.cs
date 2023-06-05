using System;

namespace Gestion.Parc.Informatique.Data;

public interface IEntityBase
{
    Guid Id { get; set; }
    string ExtraProperties { get; set; }
    bool IsDeleted { get; set; }
    DateTime CreationTimeUtc { get; set; }
    public int Order { get; set; }
}

