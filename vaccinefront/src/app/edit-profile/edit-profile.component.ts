import { Component, OnInit} from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';
import { Router } from '@angular/router';
@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent implements OnInit {
  user?: User ;
  save() :void {
    this.newUser();
    this.router.navigateByUrl('user-details'); 
  }
  constructor(private router: Router) { }
  
  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');

    // this.data.currentUser?.subscribe(user => this.user = user )
  }
newUser() {

    localStorage.setItem('fullUser',JSON.stringify(this.user));
 // this.data.changeUser();
}
}
