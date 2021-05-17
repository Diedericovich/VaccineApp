import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../user';
import { map } from 'rxjs/operators';
import { Register } from '../register';
@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  constructor() { }
}
