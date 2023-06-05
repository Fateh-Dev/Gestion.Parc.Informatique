import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { AuthService } from './Services/auth.service';
import { UserService } from './Services/user.service';
@Injectable()
export class AuthGuard implements CanActivate {
  constructor(private userService: UserService, private authService: AuthService, private router: Router) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): any {
    if (this.authService.isLoggedIn()) {
      // this.userService.getCurrentUser().subscribe(
      //   () => {
      //     // User data loaded successfully, allow access to the requested route
      //     return true;
      //   },
      //   () => {
      //     // Error loading user data, redirect to login page or show an error message
      //     this.router.navigate(['/login']);
      //     return false;
      //   }
      // );
    } else {
      // User is not logged in, redirect to login page
      this.router.navigate(['/login']);
      return false;
    }
  }
}
