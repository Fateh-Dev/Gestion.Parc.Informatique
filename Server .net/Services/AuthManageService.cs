namespace Gestion.Parc.Informatique.Service;
using AutoMapper;
using BCrypt.Net;
using Gestion.Parc.Informatique.Authorization;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Helpers;
using Gestion.Parc.Informatique.Models.Auth;
using Microsoft.EntityFrameworkCore;

public interface IAuthManageService
{
    void CreateRole(RoleCreateDto model);
    Role GetRole(int roleId);
    void AddRoleToUser(UserRoleCreateDto model);
    Permission CreatePermission(PermissionCreateDto model);
    void CreatePermissionRange(List<PermissionCreateDto> model);
    Task AddPermissionsToRole(int roleId, List<PermissionCreateDto> permissionsList);
    RolePermission AddOnePermissionToRole(int roleId, string permission);
    RolePermission RemoveOnePermissionToRole(int roleId, string permission);
    UserWithRoleDto GetUserWithRoles(int id);
    UserWithPermissionDto GetUserWithPermissions(int id);

    //----------------------------------------

    List<Role> GetAllRoles();
    List<User> GetAllUsers();
    List<Permission> GetAllPermissions();

}

public class AuthManageService : IAuthManageService
{
    private AppDbContext _context;
    private IJwtUtils _jwtUtils;
    private readonly IMapper _mapper;

    public AuthManageService(
        AppDbContext context,
        IJwtUtils jwtUtils,
        IMapper mapper)
    {
        _context = context;
        _jwtUtils = jwtUtils;
        _mapper = mapper;
    }

    public void CreateRole(RoleCreateDto model)
    {
        // validate
        if (_context._Roles.Any(x => x.RoleName == model.RoleName))
            throw new AppException("Role '" + model.RoleName + "' is already taken");

        // save user

        var role = _mapper.Map<Role>(model);
        _context._Roles.Add(role);
        _context.SaveChanges();
    }

    public void AddRoleToUser(UserRoleCreateDto model)
    {
        // validate
        if (_context._UserRoles.Any(x => x.UserId == model.UserId && x.RoleId == model.RoleId))
            throw new AppException("Role is already given to this User");

        // save user

        var userRole = _mapper.Map<UserRole>(model);
        _context._UserRoles.Add(userRole);
        _context.SaveChanges();
    }

    public Permission CreatePermission(PermissionCreateDto model)
    {
        // validate
        if (_context._Permissions.Any(x => x.PermissionName == model.PermissionName))
            throw new AppException("Permission is already saved");

        var permission = _mapper.Map<Permission>(model);
        // save user
        _context._Permissions.Add(permission);
        _context.SaveChanges();
        return permission;
    }

    public void CreatePermissionRange(List<PermissionCreateDto> model)
    {
        foreach (var item in model.ToList())
        {
            // validate
            if (_context._Permissions.Any(x => x.PermissionName == item.PermissionName))
                model.Remove(item);
        }

        var permissions = _mapper.Map<List<Permission>>(model);
        _context._Permissions.AddRange(permissions);
        _context.SaveChanges();
    }

    public async Task AddPermissionsToRole(int roleId, List<PermissionCreateDto> permissionsList)
    {
        var toRemove = _context._RolePermissions.Where(o => o.RoleId == roleId).ToList();
        _context._RolePermissions.RemoveRange(toRemove);

        foreach (var item in permissionsList.ToList())
        {

            // fix if remove permissions
            var permission = await _context._Permissions.FirstOrDefaultAsync(x => x.PermissionName == item.PermissionName);

            if (permission == null)
            { // create permission
                permission = CreatePermission(new PermissionCreateDto()
                {
                    PermissionName = item.PermissionName
                });

            }
            var model = new RolePermission()
            {
                RoleId = roleId,
                PermissionName = item.PermissionName,
                PermissionId = permission.Id
            };
            _context._RolePermissions.Add(model);

        }

        _context.SaveChanges();
    }

    public Role GetRole(int roleId)
    {
        return _context._Roles.Find(roleId);
    }

    private UserWithRoleDto getUser(int id)
    {
        var user = _context._Users.Where(o => o.Id == id).Select(x => new UserWithRoleDto
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Username = x.Username,
            RoleIds = x.Roles.Select(r => r.RoleId).ToList()
        }).FirstOrDefault();
        if (user == null) throw new KeyNotFoundException("User not found");
        return user;
    }

    public UserWithRoleDto GetUserWithRoles(int id)
    {
        return getUser(id);
    }

    public UserWithPermissionDto GetUserWithPermissions(int id)
    {
        var user = _context._Users.Find(id);

        if (user == null) throw new KeyNotFoundException("User not found");


        var userPermissions = _context._UserRoles
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

    public List<Role> GetAllRoles()
    {
        return _context._Roles.ToList();
    }

    public List<User> GetAllUsers()
    {
        return _context._Users.ToList();
    }

    public List<Permission> GetAllPermissions()
    {
        return _context._Permissions.ToList();
    }

    public RolePermission AddOnePermissionToRole(int roleId, string permission)
    {
        var per = _context._Permissions.Where(o => o.PermissionName == permission).FirstOrDefault();
        var r = new RolePermission() { RoleId = roleId, PermissionId = per.Id, PermissionName = permission };
        _context._RolePermissions.Add(r);
        _context.SaveChanges();
        return r;
    }

    public RolePermission RemoveOnePermissionToRole(int roleId, string permission)
    {
        var per = _context._RolePermissions.Where(o => o.PermissionName == permission && roleId == roleId).FirstOrDefault();
        _context._RolePermissions.Remove(per);
        _context.SaveChanges();
        return per;
    }
}