import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Cliente } from '../models/clienteModel'
import { Observable } from 'rxjs';

const API_URL = environment.apiUrl;
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class CrudService {

  constructor(private http: HttpClient) {}

  //método carregar todos
  public GetAll(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>(API_URL + '/api/Cliente');
  }

  //método inserir
  public Insert(data: any): Observable<any>{
    return this.http.post<any>('https://localhost:7298/api/Cliente', data);
  }
}