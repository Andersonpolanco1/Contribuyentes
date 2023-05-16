import { Component, OnInit } from '@angular/core';
import { Contribuyente } from '../modelos/contribuyente';
import { ContribuyentesService } from '../services/contribuyentes.service';

@Component({
  selector: 'app-listacontribuyentes',
  templateUrl: './listacontribuyentes.component.html',
  styleUrls: ['./listacontribuyentes.component.css']
})

export class ListacontribuyentesComponent implements OnInit{

  title = 'Lista de contribuyentes';
  contribuyentes: Contribuyente[] = [];
  p: number = 1;
  total: number = 0;

  constructor(private contribuyenteService:ContribuyentesService){}

  ngOnInit(): void {
    this.obtenerContribuyentes();
    }

  obtenerContribuyentes(){
    this.contribuyenteService.obtenerContribuyentes()
      .subscribe(res => {
        this.contribuyentes = res;
        this.total = this.contribuyentes.length;
      });
  }
}

