import { Component, OnInit} from '@angular/core';
import { User } from '../interfaces/user';
import { Appointment } from '../interfaces/appointment';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent implements OnInit {
  user?: User ;
  email?: string;

  constructor(
    private router: Router,
    private userService: UserService
    ) {}
  
  ngOnInit(): void {
    this.email = JSON.parse(localStorage.getItem('user') || '{}').email;

    if (this.email) {
      this.userService.getUserByEmail(this.email).subscribe((x) => {
        this.user = x;
      });
    }
  }
    // this.data.currentUser?.subscribe(user => this.user = user )
    updateUser(user: User) {
      this.userService
      .updateUser(this.user)
      .subscribe();
      this.router.navigateByUrl('landing/user-details'); 
  
    }


}
