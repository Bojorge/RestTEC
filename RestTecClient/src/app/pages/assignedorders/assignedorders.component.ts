import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignedorders',
  templateUrl: './assignedorders.component.html',
  styleUrls: ['./assignedorders.component.css']
})
export class AssignedordersComponent implements OnInit {

  ngOnInit(): void {
  }

  pedidos;
  // Se seleccionamos o inia el valor '0' del select
  opcionSeleccionado: string  = '0';
  verSeleccion: string        = '';

  constructor(){
      this.pedidos = [1,2,3,4,5,6,7,8,9,10];
  }  

  capturar() {
      // Se pasa el valor seleccionado a la variable verSeleccion
      this.verSeleccion = this.opcionSeleccionado;
  }
}



