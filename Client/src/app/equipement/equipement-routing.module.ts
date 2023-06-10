import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundPageComponent } from '../Shared/not-found-page/not-found-page.component';
import { EquipementHomeComponent } from './equipement-home/equipement-home.component';

const routes: Routes = [
  {
    path: '', component: EquipementHomeComponent,
    // children: [
    //   { path: '', component: DashboardComponent },
    //   { path: '**', component: NotFoundPageComponent },
    // ]
  },
  { path: '**', component: NotFoundPageComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EquipementRoutingModule { }
