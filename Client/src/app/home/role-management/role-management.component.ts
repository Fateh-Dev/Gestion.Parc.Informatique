import { CdkDrag, CdkDragDrop, CdkDragPlaceholder, CdkDropList, moveItemInArray } from '@angular/cdk/drag-drop';
import { NgFor } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppStoreService } from 'src/app/Shared/Services/app-store.service';
import { Permission, Role, rolePermission } from 'src/app/Shared/models';
export class Item {
  idRole?: number;
  permissions?: string;

  constructor(idRole: number, permissions: string) {
    this.idRole = idRole;
    this.permissions = permissions;
  }
}
interface permissionDto {
  permissionName: string;
  description: string;
}
interface RoleDto {
  idRole: number;
  permissions: permissionDto[];
}
@Component({
  selector: 'app-role-management',
  templateUrl: './role-management.component.html',
  styleUrls: ['./role-management.component.css']
})
export class RoleManagementComponent implements OnInit {
  roles: Role[] = [];
  permissions: Permission[] = [];

  payload: Item[] = [];
  loading = false;
  constructor(public toastr: ToastrService,
    public appStoreService: AppStoreService) {
    this.requestApi();
  }
  ngOnInit(): void {
  }
  checkIt(checked: boolean, idRole: number, permissionName: string) {
    if (checked) {
      this.payload.push(new Item(idRole, permissionName))
      // Send Logic

    }
    else {
      // Remove Logic
      this.payload = this.payload.filter((item: Item) => {
        return !(item.idRole === idRole && item.permissions === permissionName);
      });
    }
    console.log(this.payload)
  }

  submitChanges() {
    const output: RoleDto[] = this.payload.reduce((result: RoleDto[], item) => {
      const existingRole = result.find(role => role.idRole === item.idRole);
      if (existingRole) {
        existingRole.permissions.push({
          permissionName: (item.permissions as string).toUpperCase(),
          description: "-"
        });
      } else {
        result.push({
          idRole: item.idRole as number,
          permissions: [{
            permissionName: (item.permissions as string).toUpperCase(),
            description: "-"
          }]
        });
      }
      return result;
    }, []);

    this.appStoreService.addPermissionToRole(output).subscribe(e => {
      this.toastr.success("done")
    },
      e => {
        this.toastr.error("done")
      })
  }

  requestApi() {
    this.loading = true;
    this.appStoreService.loadPermissions().subscribe(e => {
      this.permissions = e;
      this.appStoreService.loadRoles().subscribe(e => {
        this.roles = e;
        this.loading = false;
      },
        e => {
          this.toastr.error("You don't Have Permission to load roles")
        })
    },
      e => {
        this.toastr.error("You don't Have Permission to load permissions")
      })
  }

}
