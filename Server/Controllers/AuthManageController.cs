using AutoMapper; // Import necessary namespaces
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Models.Auth;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

// Apply authorization to all actions in this controller
[Authorize]
[ApiController]
[Route("[controller]")]

// Configure API Explorer settings for this controller
[ApiExplorerSettings(GroupName = "Authentications")]
public class AuthManageController : ControllerBase
{
    private IAuthManageService _authManageService;
    private IMapper _mapper;

    public AuthManageController(
        IAuthManageService authManageService,
        IMapper mapper)
    {
        _authManageService = authManageService;
        _mapper = mapper;
    }

    // Get user information with permissions
    [HttpGet("getUserWithPermissions")]
    public IActionResult GetUserWithPermissions(int id)
    {
        return Ok(_authManageService.GetUserWithPermissions(id));
    }

    // Get user information with roles
    [HttpGet("getUserWithRoles")]
    public IActionResult GetUserWithRoles(int id)
    {
        return Ok(_authManageService.GetUserWithRoles(id));
    }

    // Create a role
    [HttpPost("createRole")]
    public IActionResult CreateRole(RoleCreateDto model)
    {
        _authManageService.CreateRole(model);
        return Ok(new { message = "Registration successful" });
    }

    // Create a role for a user
    [HttpPost("createRoleForUser")]
    public IActionResult CreateRoleForUser(UserRoleCreateDto model)
    {
        _authManageService.AddRoleToUser(model);
        return Ok(new { message = "Registration successful" });
    }

    // Create a permission
    [HttpPost("createPermission")]
    public IActionResult CreatePermission(PermissionCreateDto model)
    {
        _authManageService.CreatePermission(model);
        return Ok(new { message = "Registration successful" });
    }

    // Create a range of permissions
    [HttpPost("createPermissionRange")]
    public IActionResult CreatePermissionRange(List<PermissionCreateDto> model)
    {
        _authManageService.CreatePermissionRange(model);
        return Ok(new { message = "Registration successful" });
    }

    // Add permissions to a role
    [HttpPost("AddPermissionToRole")]
    public async Task<IActionResult> AddPermissionToRole(int idRole, List<PermissionCreateDto> model)
    {
        await _authManageService.AddPermissionsToRole(idRole, model);
        return Ok(new { message = "Registration successful" });
    }

    // Add permissions to multiple roles
    [HttpPost("addPermissionToRoleList")]
    public async Task<IActionResult> addPermissionToRoleList([FromBody] List<RoleWithListPermissions> items)
    {
        foreach (var item in items)
        {
            await _authManageService.AddPermissionsToRole(item.IdRole, item.Permissions);
        }

        return Ok(new { message = "Registration successful" });
    }

    // Get a list of all roles
    [HttpGet("getAllRoles")]
    public IActionResult GetAllRoles()
    {
        return Ok(_authManageService.GetAllRoles());
    }

    // Get a list of all users
    [HttpGet("getAllUsers")]
    public IActionResult GetAllUsers()
    {
        return Ok(_authManageService.GetAllUsers());
    }

    // Get a list of all permissions
    [HttpGet("getAllPermissions")]
    public IActionResult GetAllPermissions()
    {
        return Ok(_authManageService.GetAllPermissions());
    }

    // Remove a permission from a role
    [HttpPost("removePermissionFromRole")]
    public IActionResult removePermissionFromRole([FromBody] RolePermissionCreateDto item)
    {
        return Ok(_authManageService.RemoveOnePermissionToRole(item.RoleId, item.PermissionName));
    }
}
