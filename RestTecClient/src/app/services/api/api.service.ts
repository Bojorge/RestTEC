import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  
  private options = {
    headers : {
      'Content-Type' : 'application/json'
    }
  };

  constructor(private http:HttpClient) {
   }

   getAlgo(){
     

     this.http.get('https://localhost:44301/api/login').subscribe(resp => {
       console.log(resp)
     });
   }


}
