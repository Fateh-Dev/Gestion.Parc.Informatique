
import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppStoreService } from 'src/app/Shared/Services/app-store.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent {
  settings = {};
  loading = false;
  constructor(public toastr: ToastrService,
    public appStoreService: AppStoreService) {
    this.requestApi();
  }

  requestApi() {
    this.loading = true;
    this.appStoreService.loadSettings().subscribe(e => {
      this.settings = e;
      this.loading = false;
    })
  }
}
