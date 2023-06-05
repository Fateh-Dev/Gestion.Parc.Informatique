import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AppStoreService } from 'src/app/Shared/Services/app-store.service';
import { AuthService } from 'src/app/Shared/Services/auth.service';
import { SettingService } from 'src/app/Shared/Services/setting.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(public toastr: ToastrService,
    private router: Router, public authService: AuthService) {
  }
  ngOnInit(): void {
  }

  logout() {
    // Remove token and userId From localStorage
    this.router.navigate(['/authentication']);
    this.toastr.success('Logout Success ', 'Success', { positionClass: 'toast-bottom-center' });
  }

}
