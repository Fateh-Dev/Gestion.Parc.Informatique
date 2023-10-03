import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppStoreService {

  private apiUrl = 'https://localhost:8000';

  constructor(public http: HttpClient) { }

  loadSettings() {
    return this.http.get<any>("https://localhost:8000/settings/Gestion.Parc.Informatique");
  }
  loadUsers() {
    return this.http.get<any>("https://localhost:8000/Users");
  }
  loadCurrentUser() {
    return this.http.get<any>("https://localhost:8000/Users/current");
  }
  loadUsersWthRoles() {
    return this.http.get<any>("https://localhost:8000/AuthManage/getUserWithRoles/1");
  }
  loadRoles() {
    return this.http.get<any>("https://localhost:8000/AuthManage/getAllRoles");
  }
  loadPermissions() {
    return this.http.get<any>("https://localhost:8000/AuthManage/getAllPermissions");
  }
  addPermissionToRole(data: any) {
    return this.http.post<any>("https://localhost:8000/AuthManage/addPermissionToRoleList", data);
  }

  
  callScraber() {
    return this.http.get<any>("https://localhost:8000/WebScraber/webSccrab");
  }

}

export interface User {
  id: number;
  username: string;
  firstName: string;
  lastName: string;
  permissionNames: string[];

  // Other user properties
}
