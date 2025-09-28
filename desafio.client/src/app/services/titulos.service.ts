import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TitulosService {
  listaTitulos: any;


  constructor(private http: HttpClient) { }

  GetTitulosLista() {
    const url = "https://localhost:7162/api/TitulosControllers";
    return this.http.get(url);
  }
}
