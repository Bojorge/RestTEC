import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import { catchError, retry } from 'rxjs/operators';
import { Iuser } from 'src/app/interface/user';
import { throwError } from 'rxjs';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  
  private _url: string = "";

  private options = {
    headers : {
      'Content-Type' : 'application/json'
    }
  };

  constructor(private http:HttpClient) {
   }
/*
   registeredusers(){    
     this.http.get('https://localhost:44301/api/login').subscribe(resp => {
      console.log(resp);
     });
   }
   */

   registeredusers() {    
    this.http.get<Iuser[]>('https://localhost:44301/api/login').subscribe(resp => {
     console.log(resp);
    });
  }

   validateuser(user: string){
    //this.http.post('https://localhost:44301/api/login', user);
     console.log(this.http.post('https://localhost:44301/api/login', user));
   }


}
