import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../models/clienteModel';
import { CrudService } from '../../servicos/crudService';

@Component({
  selector: 'app-lista-clientes',
  templateUrl: './lista-clientes.component.html',
  styleUrls: ['./lista-clientes.component.css']
})

export class ListaClientesComponent implements OnInit  {
  clientes: Cliente[] = [];

  constructor(private crudService: CrudService) { }

  ngOnInit(){
    this.crudService.GetAll().subscribe(clientes => {this.clientes = clientes});
  };
}

