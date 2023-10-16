import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import axios from 'axios';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;


  constructor(private http: HttpClient) { }
  async ngOnInit() {


    this.eventos = await this.getEventos();
    console.log(this.eventos);

  }



  public async getEventos() {

   const listaEventos = await axios.get("https://localhost:5001/api/eventos");

   return listaEventos.data;

  }

}
