namespace Gestion.Parc.Informatique.Data;
public class UserWithRoleDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> RoleIds { get; set; }
}
public class UserWithPermissionDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> PermissionNames { get; set; }
}
public class UserRoleCreateDto
{

    public int UserId { get; set; }
    public int RoleId { get; set; }
}
public class RoleCreateDto
{

    public string RoleName { get; set; }
}

public class RolePermissionCreateDto
{

    public int RoleId { get; set; }
    public int PermissionId { get; set; }
    public string PermissionName { get; set; }
}

public class PermissionCreateDto
{
    public string PermissionName { get; set; }
    public string Description { get; set; }
}