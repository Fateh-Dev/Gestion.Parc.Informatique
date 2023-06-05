using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.EntityFrameworkCore;

public class PermissionRepository
{
    private readonly AppDbContext _dbContext;

    public PermissionRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Permission> RetrievePermissionsFromDatabase()
    {
        return _dbContext._Permissions.ToList();
    }
    public UserWithPermissionDto GetUserWithPermissions(int id)
    {
        var user = _dbContext._Users.Find(id);

        if (user == null) throw new KeyNotFoundException("User not found");


        var userPermissions = _dbContext._UserRoles
            .Include(ur => ur.Role)
                .ThenInclude(r => r.Permissions)
            .Include(ur => ur.User)
            .Where(ur => ur.UserId == id)
            .SelectMany(ur => ur.Role.Permissions.Select(p => p.PermissionName))
            .Distinct()
            .ToList();

        var userWithPermissions = new UserWithPermissionDto
        {
            Id = id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Username = user.Username,
            PermissionNames = userPermissions
        };

        return userWithPermissions;
    }
}