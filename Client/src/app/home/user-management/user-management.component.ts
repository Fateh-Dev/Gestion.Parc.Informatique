import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppStoreService } from 'src/app/Shared/Services/app-store.service';

@Component({
  selector: 'app-user-management',
  templateUrl: './user-management.component.html',
  styleUrls: ['./user-management.component.css']
})
export class UserManagementComponent implements OnInit {
  users = {};
  loading = false;
  constructor(public toastr: ToastrService,
    public appStoreService: AppStoreService) {
    this.requestApi();
  }
  ngOnInit(): void {
  }

  requestApi() {
    this.loading = true;
    this.appStoreService.loadUsers().subscribe(e => {
      this.users = e;
      this.loading = false;
    },
      e => {
        this.toastr.error("You don't Have Permission to load Users")
      })
  }
}
