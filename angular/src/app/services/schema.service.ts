import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable()
export class SchemaService {
  private url = environment.domain + 'api/Schema/';
  constructor(private http: HttpClient) { }

  public getSchema(context: string, schema: string): Observable<object> {
    return this.http.get(this.url + `${context}` + `/${schema}`);
  }
}
