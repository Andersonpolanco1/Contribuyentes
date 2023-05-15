import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Contribuyente } from '../modelos/contribuyente';
import { ComprobanteFiscal } from '../modelos/comprobantefiscal';


@Injectable({
  providedIn: 'root'
})
export class ContribuyentesService {

  constructor(private http : HttpClient) { }

  API_BASE_URL: string ="https://localhost:7291/api/";
  CONTRIBUYENTES_URL: string = this.API_BASE_URL + "contribuyentes/";
  COMPROBANTES_CONTRIBUYENTE_URL: string = this.CONTRIBUYENTES_URL + "/:rncCedula/comprobantes";



  obtenerContribuyentes() : Observable<Contribuyente[]>{
    return this.http.get<Contribuyente[]>(this.CONTRIBUYENTES_URL);
  }


  obtenerComprobantes(rncCedula : string) : Observable<ComprobanteFiscal[]>{
    return this.http.get<ComprobanteFiscal[]>(this.CONTRIBUYENTES_URL + rncCedula+"/comprobantes/");
  }

  obtenerContribuyente(rncCedula : string) : Observable<Contribuyente>{
    return this.http.get<Contribuyente>(this.CONTRIBUYENTES_URL + rncCedula);
  }}
