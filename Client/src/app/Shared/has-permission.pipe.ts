import { Pipe, PipeTransform } from '@angular/core';
import { AuthService } from './Services/auth.service';
import { Observable } from 'rxjs';

@Pipe({
  name: 'hasPermission'
})
export class HasPermissionPipe implements PipeTransform {
  constructor(private authService: AuthService) { }

  transform(permission: string): Observable<boolean> {
    return this.authService.hasPermission(permission);
  }
}