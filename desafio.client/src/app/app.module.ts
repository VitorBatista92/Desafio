import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListarTituloComponent } from './components/listar-titulo/listar-titulo.component';
import { VerTitulosComponent } from './components/ver-titulos/ver-titulos.component';

@NgModule({
  declarations: [
    AppComponent,
    ListarTituloComponent,
    VerTitulosComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
