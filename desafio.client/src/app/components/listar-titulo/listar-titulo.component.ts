import { Component, inject } from '@angular/core';
import { TitulosService } from '../../services/titulos.service';
import { NavigationExtras, Router } from '@angular/router';
import { TituloTransportService } from '../../services/titulo-transport.service';

@Component({
  selector: 'app-listar-titulo',
  standalone: false,
  templateUrl: './listar-titulo.component.html',
  styleUrl: './listar-titulo.component.css'
})
export class ListarTituloComponent {
  listaTitulos: any;

  constructor(private tituloService: TitulosService, private tituloTransportService: TituloTransportService, private router: Router) {

  }


  ngOnInit() {
    this.tituloService.GetTitulosLista().subscribe((data) => {
      this.listaTitulos = data;
    });
  }

  VerTitulo(data: any) {
    this.tituloTransportService.titulo = data;
    this.router.navigate(['VerTitulo']);

  }

}
