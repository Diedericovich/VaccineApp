import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BodyComponent } from './body/body.component';
import { HeadVaccinsComponent } from './head-vaccins/head-vaccins.component';
import { TorsoVaccinsComponent } from './torso-vaccins/torso-vaccins.component';
import { LegsVaccinsComponent } from './legs-vaccins/legs-vaccins.component';
import { LeftArmVaccinsComponent } from './left-arm-vaccins/left-arm-vaccins.component';
import { RightArmVaccinsComponent } from './right-arm-vaccins/right-arm-vaccins.component';
import { VaccineDetailComponent } from './vaccine-detail/vaccine-detail.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { NavigationComponent } from './navigation/navigation.component';
import { AppointmentsComponent } from './appointments/appointments.component';
import { AllVaccinsComponent } from './all-vaccins/all-vaccins.component';
import { RegisterComponent } from './register/register.component';
import { EditProfileComponent } from './edit-profile/edit-profile.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { LandingpageComponent } from './landingpage/landingpage.component';
import { VaccinationCenterMapComponent } from './vaccinationcenter-map/vaccinationcenter-map.component';


@NgModule({
    declarations: [
        AppComponent,
        BodyComponent,
        HeadVaccinsComponent,
        TorsoVaccinsComponent,
        LegsVaccinsComponent,
        LeftArmVaccinsComponent,
        RightArmVaccinsComponent,
        VaccineDetailComponent,
        UserDetailsComponent,
        NavigationComponent,
        AppointmentsComponent,
        AllVaccinsComponent,
        RegisterComponent,
        EditProfileComponent,
        LoginComponent,
        LandingpageComponent,
        VaccinationCenterMapComponent,

    ],
    imports: [
        BrowserModule,
        FormsModule,
        ReactiveFormsModule,
        AppRoutingModule,
        NoopAnimationsModule,
        HttpClientModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }