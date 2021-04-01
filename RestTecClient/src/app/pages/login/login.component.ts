import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api/api.service'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  respuesta: string[]=[];

  constructor(private apiService: ApiService) { 
    this.apiService.getAlgo();
  }

  ngOnInit(): void {
  }

  async getAlgoComp(){
    //this.respuesta = await this.
  }

}
