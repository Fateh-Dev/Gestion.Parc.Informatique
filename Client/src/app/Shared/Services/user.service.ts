import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'https://localhost:8000';

  constructor(private http: HttpClient) { }

  // Function to get the current user's information with an authenticated token
  getCurrentUser(id: number, token: string): Observable<User> {
    // Construct the URL for the API endpoint
    const url = `${this.apiUrl}/AuthManage/getUserWithPermissions?id=` + id;

    // Create HTTP headers with the 'Authorization' header containing the token
    const headers = new HttpHeaders({
      'Authorization': `Bearer ${token}`
    });

    // Make an HTTP GET request to fetch the user's data with the provided headers
    return this.http.get<User>(url, { headers: headers });
  }
}

// Define the structure of the User object
interface User {
  id: number;
  username: string;
  firstName: string;
  lastName: string;
  permissionNames: string[];
  // Other user properties
}
