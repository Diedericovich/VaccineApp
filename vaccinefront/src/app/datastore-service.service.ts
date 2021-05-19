import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { User } from './user';
import { Appointment } from './appointment';
@Injectable({
  providedIn: 'root'
})
export class DatastoreService {
private localUser = new BehaviorSubject<User>({
  id:1,
  email: "ward@impesoft.com",
  firstName: "Ward",
  surName:"Impe",
  address:"Tervenen 47F, 9940, Ertvelde, België",
  birthDate : new Date(1974, 4,19,4,50),
  appointments: [] as Appointment[]
});
currentUser = this.localUser.asObservable();

constructor() { 
  
  }

  changeUser(user: User) {
    this.localUser.next(user)
  }
}
