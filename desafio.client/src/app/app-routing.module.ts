import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListarTituloComponent } from './components/listar-titulo/listar-titulo.component';
import { VerTitulosComponent } from './components/ver-titulos/ver-titulos.component';

const routes: Routes = [
  { path: '', component: ListarTituloComponent },
  { path: 'VerTitulo', component: VerTitulosComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
