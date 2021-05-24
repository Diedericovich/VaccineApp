import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css'],
})
export class NavigationComponent implements OnInit {
  title = 'Vaxx.id';

  constructor(private router: Router) {}

  ngOnInit(): void {}

  logout(): void {
    localStorage.removeItem('user');
    window.location.href = '/';
  }
}
