import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IFilter } from '../base-elements/grid/Grid';

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

  public getAllByFilters(url: string, filters: IFilter[] = null): Observable<any> {
    let param = {};
    if (filters && filters.length > 0) {
      param = {
        propertyNames: filters.map(x => x.propertyName),
        values: filters.map(x => x.value)
      };
    }
    return this.http.get(`${this.domainUrl}/${url}`, {
      params: param
    });
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
