import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'https://localhost:8000';

  constructor(private http: HttpClient) { }

  getCurrentUser(id: number): Observable<User> {
    const url = `${this.apiUrl}/AuthManage/getUserWithPermissions?id=` + id;
    return this.http.get<User>(url);
  }
}

interface User {
  id: number;
  username: string;
  firstName: string;
  lastName: string;
  permissionNames: string[];
  // Other user properties
}
