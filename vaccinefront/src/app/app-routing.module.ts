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
import { AllVaccinsComponent } from './all-vaccins/all-vaccins.component';
import { EditProfileComponent } from './edit-profile/edit-profile.component';
import { RegisterComponent } from './register/register.component';
const routes: Routes = [
  { path: '', redirectTo: '', pathMatch: 'full' },
  { path: 'register', component: RegisterComponent},
  { path: 'appointments', component: AppointmentsComponent},
  { path: 'edit-profile', component: EditProfileComponent},
  { path: 'user-details', component: UserDetailsComponent},
  { path: 'body', component: BodyComponent, children: [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'head', component: HeadVaccinsComponent },
    { path: 'leftarm', component: LeftArmVaccinsComponent },
    { path: 'torso', component: TorsoVaccinsComponent },
    { path: 'rightarm', component: RightArmVaccinsComponent },
    { path: 'legs', component: LegsVaccinsComponent },
    { path: 'home', component: AllVaccinsComponent}

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
