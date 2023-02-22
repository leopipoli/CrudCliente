import { Component, OnInit } from '@angular/core';
import { Cliente } from '../../models/clienteModel';
import { CrudService } from '../../servicos/crudService';

@Component({
  selector: 'app-editar-clientes',
  templateUrl: './editar-clientes.component.html',
  styleUrls: ['./editar-clientes.component.css']
})

export class EditarClientesComponent {
  cliente: Cliente = {
    nome: '',
    cpf: '',
    endereco: ''
  };

  constructor(private crudService: CrudService) { }

  salvar(){
    this.crudService.Insert(this.cliente);
  }
}
