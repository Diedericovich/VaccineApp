import { Component, OnInit} from '@angular/core';
import { User } from '../user';
import { Appointment } from '../appointment';
import { Router } from '@angular/router';
import { DatastoreService } from '../datastore-service.service';
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
  constructor(private router: Router, private data: DatastoreService) { }
  
  ngOnInit(): void {
    this.data.currentUser.subscribe(user => this.user = user )
  }
newUser() {
 // this.data.changeUser();
}
}
