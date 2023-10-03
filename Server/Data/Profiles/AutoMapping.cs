using AutoMapper;
using Gestion.Parc.Informatique.Models.Auth;
using Gestion.Parc.Informatique.Service;

namespace Gestion.Parc.Informatique.Data;

public class AutoMapping : Profile
{

    private readonly ISharedFunctionService _sharedFunc;
    public AutoMapping()
    {
        CreateMap<Settings, SettingsReturnDto>();
        CreateMap<SettingsCreateDto, Settings>();

        CreateMap<Structure, StructureReturnDto>();
        CreateMap<StrcutureCreateDto, Structure>();
        CreateMap<Structure, StructureWithChildrenDto>();


        CreateMap<UserRole, UserRoleCreateDto>();
        CreateMap<Role, RoleCreateDto>();
        CreateMap<RolePermission, RolePermissionCreateDto>();
        CreateMap<Permission, PermissionCreateDto>();

        CreateMap<UserRoleCreateDto, UserRole>();
        CreateMap<RoleCreateDto, Role>();
        CreateMap<RolePermissionCreateDto, RolePermission>();
        CreateMap<PermissionCreateDto, Permission>();

    }
}