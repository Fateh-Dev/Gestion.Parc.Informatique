
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion.Parc.Informatique.Data;

public abstract class EntityMapBase<TEntity> : IEntityMap<TEntity> where TEntity : class, IEntityBase
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasQueryFilter(t => t.IsDeleted == false);
    }
}
