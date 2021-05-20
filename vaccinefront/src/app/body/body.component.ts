import { Component, OnInit } from '@angular/core';
import { User } from '../user';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent implements OnInit {
user? : User;
  constructor() { }

  ngOnInit(): void {
    this.user = JSON.parse(localStorage.getItem('fullUser')||'{}');
    console.log(this.user);
  }

}
