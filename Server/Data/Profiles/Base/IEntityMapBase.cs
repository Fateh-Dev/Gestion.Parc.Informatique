using Microsoft.EntityFrameworkCore;
namespace Gestion.Parc.Informatique.Data;

public interface IEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
{

}
