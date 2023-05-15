import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ContribuyentesService } from '../services/contribuyentes.service';
import { ComprobanteFiscal } from '../modelos/comprobantefiscal';
import { Contribuyente } from '../modelos/contribuyente';
import { Location } from '@angular/common';

@Component({
  selector: 'app-comprobantescontribuyente',
  templateUrl: './comprobantescontribuyente.component.html',
  styleUrls: ['./comprobantescontribuyente.component.css']
})

export class ComprobantescontribuyenteComponent implements OnInit {
  
  constructor(
    private route: ActivatedRoute,
    private contribuyentesService: ContribuyentesService,
    private location: Location,
    private router: Router
  ) {}

  comprobantes: ComprobanteFiscal[] = [];
  contribuyente : Contribuyente = {
    rncCedula: '',
    nombre: '',
    tipo: '',
    estatus: ''
  };

  ngOnInit(): void {
    this.obtenerDatosContribuyente();
  }
  
  obtenerDatosContribuyente(): void {
    let rncCedula:string | null = this.route.snapshot.paramMap.get('rncCedula');

    if(rncCedula){
        this.contribuyentesService.obtenerComprobantes(rncCedula)
          .subscribe(res => this.comprobantes = res);

          this.contribuyentesService.obtenerContribuyente(rncCedula)
          .subscribe(res => this.contribuyente = res);
    }
  }

  volverAtras(): void {
    this.location.back();
  }

}
