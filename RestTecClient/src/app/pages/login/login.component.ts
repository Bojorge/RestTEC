import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from 'src/app/services/api/api.service'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  respuesta: string[]=[];

  constructor(private apiService: ApiService, private router: Router) { 
    //this.apiService.registeredusers();
  }

  ngOnInit(): void {
  }

  public confirmuser(user: string){
    //this.apiService.validateuser(user);
    if(user==""){
      console.log("ingrese el usuario");
    }
    else{
      this.apiService.registeredusers();
      this.assigned();
    }
    
  }

  public assigned(){
      this.router.navigate(['/assignedorders']); //redirecciona a la pagina de platillos asignados
  }

}
