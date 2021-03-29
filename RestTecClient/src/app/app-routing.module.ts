import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from '../app/pages/login/login.component'; //se importa un componente
import { SetdishComponent } from './pages/setdish/setdish.component';

//las rutas para usar los componentes
const routes: Routes = [
  {path:'', redirectTo:'login', pathMatch:'full'}, //componente inicial (se redirecciona al login)
  { path:'login', component:LoginComponent}, //ruta al componente login
  { path:'setdish', component:SetdishComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents=[LoginComponent,SetdishComponent]