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
    this.apiService.getAlgo();
  }

  ngOnInit(): void {
  }

  async getAlgoComp(){
    //this.respuesta = await this.
  }

  public assigned(){
      this.router.navigate(['/assignedorders']); //redirecciona a la pagina de platillos asignados
  }

}
