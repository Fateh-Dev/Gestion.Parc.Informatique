import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RestMaterialTableComponent } from './rest-material-table/rest-material-table.component';
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';
import { MaterialModule } from '../material/material.module';
import { FlexLayoutModule } from '@angular/flex-layout';

import { FormsModule } from '@angular/forms';
import { HasPermissionPipe } from './has-permission.pipe';

@NgModule({
  declarations: [
    RestMaterialTableComponent,
    NotFoundPageComponent,
    HasPermissionPipe
  ],
  imports: [
    CommonModule,
    MaterialModule,
    FormsModule,
    FlexLayoutModule
  ],
  exports: [
    NotFoundPageComponent,
    RestMaterialTableComponent,
    MaterialModule,
    FormsModule,
    FlexLayoutModule,
    HasPermissionPipe
  ]
})
export class SharedModule { }
