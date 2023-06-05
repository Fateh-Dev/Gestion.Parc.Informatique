
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Gestion.Parc.Informatique.Data;

public class PersonneSeed : EntityMapBase<Personne>
{
    public override void Configure(EntityTypeBuilder<Personne> builder)
    {

        builder.HasData(
            new Personne() { Id = Guid.NewGuid(), Nom = "Djehinet", Prenom = "Djawed", Age = 1 },
            new Personne() { Id = Guid.NewGuid(), Nom = "Djehinet", Prenom = "Nadjib", Age = 32 },
            new Personne() { Id = Guid.NewGuid(), Nom = "Djehinet", Prenom = "Fateh", Age = 30 }
            );
        base.Configure(builder);
    }
}
