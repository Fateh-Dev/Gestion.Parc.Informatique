import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, map } from 'rxjs';
import { User } from './app-store.service';
import { HttpClient } from '@angular/common/http';
import { UserService } from './user.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

// Define a class for the server response
export class Response {
  firstName: string | undefined;
  id: number | undefined;
  lastName: string | undefined;
  token: string | undefined;
  username: string | undefined;
}

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:8000';
  private isLoggedInValue: boolean = false;

  // BehaviorSubject to hold the current user state
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser$: Observable<User>;

  constructor(private http: HttpClient,
    private userService: UserService,
    public toastr: ToastrService,
    private router: Router) {
    // Initialize the currentUserSubject with an initial value of an empty user object
    this.currentUserSubject = new BehaviorSubject<User>({} as User);
    this.currentUser$ = this.currentUserSubject.asObservable();
    // Check if a token exists in local storage upon AuthService initialization
    this.loadCurrentUser();
  }

  // Method to load the current user from the server
  loadCurrentUser() {
    const userId = localStorage.getItem('userId');
    const token = localStorage.getItem('token');
    if (userId) {
      this.userService.getCurrentUser(userId as unknown as number, token as string).subscribe(
        (user: User) => { this.currentUserSubject.next(user) },
        () => this.currentUserSubject.next({} as User)
      );
    }
  }

  // Method to set the current user in the BehaviorSubject
  setCurrentUser(user: User): void {
    this.currentUserSubject.next(user);
  }

  // Method to get the current user from the BehaviorSubject
  getCurrentUser(): User {
    return this.currentUserSubject.value;
  }

  // Method to handle user login
  login(loginForm: any): void {
    const url = this.apiUrl + '/Users/authenticate';
    // Set isLoggedInValue to true upon successful login
    this.isLoggedInValue = true;
    this.http.post<Response>(url, loginForm).subscribe((e) => {
      let res = e;
      this.userService.getCurrentUser(res.id as number, res.token as string).subscribe(
        e => {
          this.setCurrentUser(e as User);
          // Save the token to localStorage 
          localStorage.setItem('token', res.token as string);
          localStorage.setItem('userId', res.id as any);
          this.router.navigate(['/app/dashboard']);
          this.toastr.success('Authentication Success ', 'Success', {
            positionClass: 'toast-bottom-center'
          });
        }, e => {
          this.toastr.error('Authentication Failed', 'Error', {
            positionClass: 'toast-bottom-center'
          });
        }
      )
    })
  }

  // Method to handle user logout
  logout(): void {
    // Remove token and user ID from localStorage
    localStorage.removeItem('token');
    localStorage.removeItem('userId');
    // Set isLoggedInValue to false upon successful logout
    this.isLoggedInValue = false;
  }

  // Method to check if the user is logged in
  isLoggedIn(): boolean {
    return this.isLoggedInValue;
  }

  // Method to check if the user has a specific permission
  hasPermission(permission: string): Observable<boolean> {
    return this.currentUser$.pipe(
      map((user: User) => {
        if (user) {
          return user.permissionNames.includes(permission);
        }
        return false;
      })
    );
  }
}
