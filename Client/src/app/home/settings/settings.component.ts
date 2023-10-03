
import { CdkAccordionModule } from '@angular/cdk/accordion';
import {
  CdkDrag,
  CdkDragDrop,
  CdkDragPlaceholder,
  CdkDropList,
  moveItemInArray,
} from '@angular/cdk/drag-drop';

import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AppStoreService } from 'src/app/Shared/Services/app-store.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css'],
})
export class SettingsComponent {

  items = ['Item 1', 'Item 2', 'Item 3', 'Item 4', 'Item 5'];
  expandedIndex = 0;
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
