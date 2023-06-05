using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestion.Parc.Informatique.Data;

public class UserSeed : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.HasData(
            new User() { Id = 1, FirstName = "djawed", Username = "djawed", LastName = "djehinet", PasswordHash = "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK" }
            );

    }
}
