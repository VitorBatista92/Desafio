import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TituloTransportService } from '../../services/titulo-transport.service';

@Component({
  selector: 'app-ver-titulos',
  standalone: false,
  templateUrl: './ver-titulos.component.html',
  styleUrl: './ver-titulos.component.css'
})
export class VerTitulosComponent {
  titulo: any;

  constructor(private router: Router, private tituloTransportService: TituloTransportService) {
  }

  ngOnInit() {
    this.titulo = this.tituloTransportService.titulo;
    if (this.titulo === undefined)
      this.router.navigate(['']);
  }
}
