import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UserManagementComponent } from './user-management/user-management.component';
import { RoleManagementComponent } from './role-management/role-management.component';
import { NotFoundPageComponent } from '../Shared/not-found-page/not-found-page.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsComponent } from './settings/settings.component';

const routes: Routes = [
  {
    path: '', component: HomeComponent,
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'profile', component: UserManagementComponent },
      { path: 'roles', component: RoleManagementComponent },
      { path: 'settings', component: SettingsComponent },
      { path: 'equipements', loadChildren: () => import('../equipement/equipement.module').then(m => m.EquipementModule) },
      { path: '**', component: NotFoundPageComponent },
    ]
  },
  { path: '**', component: NotFoundPageComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
