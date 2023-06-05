namespace Gestion.Parc.Informatique.Controllers;

using AutoMapper;
using Gestion.Parc.Informatique.Data;
using Gestion.Parc.Informatique.Models.Auth;
using Gestion.Parc.Informatique.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

[Authorize]
[ApiController]
[Route("[controller]")]

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
    [HttpGet("getUserWithPermissions")]
    public IActionResult GetUserWithPermissions(int id)
    {
        return Ok(_authManageService.GetUserWithPermissions(id));
    }
    [HttpGet("getUserWithRoles")]
    public IActionResult GetUserWithRoles(int id)
    {
        return Ok(_authManageService.GetUserWithRoles(id));
    }


    [HttpPost("createRole")]
    public IActionResult CreateRole(RoleCreateDto model)
    {
        _authManageService.CreateRole(model);
        return Ok(new { message = "Registration successful" });
    }

    [HttpPost("createRoleForUser")]
    public IActionResult CreateRoleForUser(UserRoleCreateDto model)
    {
        _authManageService.AddRoleToUser(model);
        return Ok(new { message = "Registration successful" });
    }


    [HttpPost("createPermission")]
    public IActionResult CreatePermission(PermissionCreateDto model)
    {
        _authManageService.CreatePermission(model);
        return Ok(new { message = "Registration successful" });
    }


    [HttpPost("createPermissionRange")]
    public IActionResult CreatePermissionRange(List<PermissionCreateDto> model)
    {
        _authManageService.CreatePermissionRange(model);
        return Ok(new { message = "Registration successful" });
    }


    [HttpPost("addPermissionToRole")]
    public async Task<IActionResult> AddPermissionToRole(int idRole, List<PermissionCreateDto> model)
    {
        await _authManageService.AddPermissionsToRole(idRole, model);
        return Ok(new { message = "Registration successful" });
    }

    [HttpGet("getAllRoles")]
    public IActionResult GetAllRoles()
    {
        return Ok(_authManageService.GetAllRoles());
    }

    [HttpGet("getAllUsers")]
    public IActionResult GetAllUsers()
    {
        return Ok(_authManageService.GetAllUsers());
    }

    [HttpGet("getAllPermissions")]
    public IActionResult GetAllPermissions()
    {
        return Ok(_authManageService.GetAllPermissions());
    }
    // [HttpPost("createPermissionToRole")]
    // public IActionResult createPermissionToRole([FromBody] RolePermissionCreateDto item)
    // {
    //     return Ok(_authManageService.AddOnePermissionToRole(item.RoleId, item.PermissionName));
    // }

    [HttpPost("removePermissionFromRole")]
    public IActionResult removePermissionFromRole([FromBody] RolePermissionCreateDto item)
    {
        return Ok(_authManageService.RemoveOnePermissionToRole(item.RoleId, item.PermissionName));
    }
}