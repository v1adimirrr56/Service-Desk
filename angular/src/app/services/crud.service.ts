import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CrudService {
  private domainUrl = environment.domain + 'api';
  constructor(private http: HttpClient) { }

  public get(url: string, id: number): Observable<any> {
    return this.http.get(`${this.domainUrl}/${url}/${id}`);
  }

  public getAll(url: string): Observable<any> {
    return this.http.get(`${this.domainUrl}/${url}`);
  }

  public post(url: string, body: any): Observable<any> {
    return this.http.post(`${this.domainUrl}/${url}`, body);
  }

  public put(url: string, id: number, body: any): Observable<any> {
    return this.http.put(`${this.domainUrl}/${url}/${id}`, body);
  }

  public delete(url: string, id: number): Observable<any> {
    return this.http.delete(`${this.domainUrl}/${url}/${id}`);
  }

}
