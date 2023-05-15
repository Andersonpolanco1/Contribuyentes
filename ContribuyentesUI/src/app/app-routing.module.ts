import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListacontribuyentesComponent } from './listacontribuyentes/listacontribuyentes.component';
import { ComprobantescontribuyenteComponent } from './comprobantescontribuyente/comprobantescontribuyente.component';


const routes: Routes = [
  { path: '', redirectTo: '/contribuyentes', pathMatch: 'full' },
  { path: 'contribuyentes', component: ListacontribuyentesComponent },
  { path: 'contribuyentes/:rncCedula', component: ComprobantescontribuyenteComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
