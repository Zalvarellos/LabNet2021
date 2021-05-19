import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.scss']
})
export class ListaComponent implements OnInit {

  conversion: any;
  respuesta: [];

  constructor(private http: HttpClient, ) { }

  ngOnInit() {
    this.http.get('https://localhost:44369/api/Categories').subscribe(data => {
      this.conversion=data;
      this.respuesta=this.conversion;
    })
  }

}
