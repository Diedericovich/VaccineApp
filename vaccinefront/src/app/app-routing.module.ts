import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BodyComponent } from './body/body.component';
import { HeadVaccinsComponent } from './head-vaccins/head-vaccins.component';
import { LeftArmVaccinsComponent } from './left-arm-vaccins/left-arm-vaccins.component';
import { LegsVaccinsComponent } from './legs-vaccins/legs-vaccins.component';
import { RightArmVaccinsComponent } from './right-arm-vaccins/right-arm-vaccins.component';
import { TorsoVaccinsComponent } from './torso-vaccins/torso-vaccins.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { AppointmentsComponent } from './appointments/appointments.component';
const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'appointments', component: AppointmentsComponent},
  { path: 'body', component: BodyComponent, children: [
    { path: 'head', component: HeadVaccinsComponent },
    { path: 'leftarm', component: LeftArmVaccinsComponent },
    { path: 'torso', component: TorsoVaccinsComponent },
    { path: 'rightarm', component: RightArmVaccinsComponent },
    { path: 'legs', component: LegsVaccinsComponent }
  ]},
  // { path: 'head', component: HeadVaccinsComponent },
  // { path: 'leftarm', component: LeftArmVaccinsComponent },
  // { path: 'torso', component: TorsoVaccinsComponent },
  // { path: 'rightarm', component: RightArmVaccinsComponent },
  { path: 'profile', component: UserDetailsComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
