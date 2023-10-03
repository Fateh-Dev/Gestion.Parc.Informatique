
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Gestion.Parc.Informatique.Data;

public class MarqueSeed : IEntityTypeConfiguration<Marque>
{
    public void Configure(EntityTypeBuilder<Marque> builder)
    {

        builder.HasData(
            new Marque() { Id = Guid.NewGuid(), Description = "HP", Order = 1, DisplayFr = "HP" },
            new Marque() { Id = Guid.NewGuid(), Description = "ACER", Order = 2, DisplayFr = "ACER" },
            new Marque() { Id = Guid.NewGuid(), Description = "FUJITSU", Order = 3, DisplayFr = "FUJITSU" },
            new Marque() { Id = Guid.NewGuid(), Description = "DELL", Order = 4, DisplayFr = "DELL" },
            new Marque() { Id = Guid.NewGuid(), Description = "TOSHIBA", Order = 5, DisplayFr = "TOSHIBA" }
            );
    }
}
public class ModelSeed : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {

        builder.HasData(
            new Model() { Id = Guid.NewGuid(), Description = "Model 1", Order = 1, DisplayFr = "Model 1" },
            new Model() { Id = Guid.NewGuid(), Description = "Model 2", Order = 2, DisplayFr = "Model 2" },
            new Model() { Id = Guid.NewGuid(), Description = "Model 3", Order = 3, DisplayFr = "Model 3" },
            new Model() { Id = Guid.NewGuid(), Description = "Model 4", Order = 4, DisplayFr = "Model 4" },
            new Model() { Id = Guid.NewGuid(), Description = "Model 5", Order = 5, DisplayFr = "Model 5" }
            );
    }
}
public class CategorySeed : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {

        builder.HasData(
            new Category() { Id = Guid.NewGuid(), Description = "Category 1", Order = 1, DisplayFr = "Category 1" },
            new Category() { Id = Guid.NewGuid(), Description = "Category 2", Order = 2, DisplayFr = "Category 2" },
            new Category() { Id = Guid.NewGuid(), Description = "Category 3", Order = 3, DisplayFr = "Category 3" },
            new Category() { Id = Guid.NewGuid(), Description = "Category 4", Order = 4, DisplayFr = "Category 4" },
            new Category() { Id = Guid.NewGuid(), Description = "Category 5", Order = 5, DisplayFr = "Category 5" }
            );
    }
}
