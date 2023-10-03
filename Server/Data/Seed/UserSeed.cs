using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion.Parc.Informatique.Data;

public class UserSeed : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.HasData(
            new User() { Id = 1, FirstName = "Djawed", Username = "Djawed", LastName = "Djehinet", PasswordHash = "$2a$11$4HvPAEP.KKlCG/N6AsvwcOoJHJiOYf2azHBInCHeqbB5YwDy6/y1C" }
            );

    }
}
