namespace Gestion.Parc.Informatique.Models.Auth;
using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }

    [JsonIgnore]
    public string? PasswordHash { get; set; }

    public virtual List<UserRole>? Roles { get; set; }
}

public class UserRole
{
    public int UserId { get; set; }
    public int RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}

public class Role
{
    public int Id { get; set; }
    public string RoleName { get; set; }

    public virtual List<RolePermission>? Permissions { get; set; }

    public virtual List<UserRole>? Users { get; set; }
}

public class RolePermission
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public int PermissionId { get; set; }
    public string PermissionName { get; set; }

    public virtual Role? Role { get; set; }

    public virtual Permission? Permission { get; set; }
}
public class Permission
{
    public int Id { get; set; }
    public string PermissionName { get; set; }
    public string Description { get; set; }

    public virtual List<RolePermission>? Roles { get; set; }
}

public class UserLogin
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
}