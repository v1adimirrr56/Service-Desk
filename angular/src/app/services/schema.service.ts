import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { FormField } from '../base-elements/form/form-field/models/FormField';

@Injectable()
export class SchemaService<T> {
  private url = environment.domain + 'api/Schema/';
  constructor(private http: HttpClient) { }

  public getSchema(schemaUrl: string): Observable<T> {
    return this.http.get<T>(this.url + `${schemaUrl}`);
  }
}
