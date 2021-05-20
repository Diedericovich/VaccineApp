import { Component, OnInit} from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent implements OnInit {
  user?: User ;
 
  constructor(
    private router: Router,
    private userService: UserService

    ) { }
  
  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');

    // this.data.currentUser?.subscribe(user => this.user = user )
  }
newUser() {

    localStorage.setItem('fullUser',JSON.stringify(this.user));
    this.userService.updateUser(this.user);
 // this.data.changeUser();
}

save() :void {
  this.newUser();
  this.router.navigateByUrl('landing/user-details'); 
}


}
