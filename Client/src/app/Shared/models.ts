export interface Role {
    id: number;
    roleName: string;
}

export interface Permission {
    id: number;
    permissionName: string;
}

export interface rolePermission {
    roleId: number;
    permissionName: string;
}