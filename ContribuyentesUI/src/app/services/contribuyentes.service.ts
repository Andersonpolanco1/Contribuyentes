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
  CONTRIBUYENTES_URL: string = this.API_BASE_URL + "contribuyentes";
  COMPROBANTES_URL: string = this.CONTRIBUYENTES_URL + "/comprobantes";

  obtenerContribuyentes() : Observable<Contribuyente[]>{
    return this.http.get<Contribuyente[]>(this.CONTRIBUYENTES_URL);
  }

  obtenerComprobantesPorRncCedula(rncCedula : string) : Observable<ComprobanteFiscal[]>{
    return this.http.get<ComprobanteFiscal[]>(this.COMPROBANTES_URL +"?rncCedula="+rncCedula);
  }

  obtenerContribuyentePorRncCedula(rncCedula : string) : Observable<Contribuyente[]>{
    return this.http.get<Contribuyente[]>(this.CONTRIBUYENTES_URL + "?rncCedula="+rncCedula);
  }}
