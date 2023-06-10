import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../Shared/shared.module';

import { EquipementRoutingModule } from './equipement-routing.module';
import { EquipementHomeComponent } from './equipement-home/equipement-home.component';


@NgModule({
  declarations: [
    EquipementHomeComponent
  ],
  imports: [
    CommonModule,
    EquipementRoutingModule,
    SharedModule
  ]
})
export class EquipementModule { }
