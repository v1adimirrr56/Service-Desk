import { Component, OnInit } from '@angular/core';
import { SchemaService } from '../../../services/schema.service';
import { CrudService } from '../../../services/crud.service';
import { SchemaBuilder } from '../../models/Schema-builder';
import { Grid, IFilter } from '../Grid';
import { forkJoin } from 'rxjs';
import { $e } from 'codelyzer/angular/styles/chars';

@Component({
  selector: 'app-grid-container',
  templateUrl: './grid-container.component.html',
  styleUrls: ['./grid-container.component.sass']
})
export abstract class GridContainerComponent extends SchemaBuilder implements OnInit {
  schema: Grid;
  data: any[];
  private isLoaded: boolean;

  private getSchemaUrl() {
    return `${this.getContext()}/${this.getSchema()}/Grids`;
  }
  private getDataUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }
  private getDataUpdateUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }

  constructor(
    private schemaService: SchemaService<Grid>,
    private crudService: CrudService) {
    super();
  }

  ngOnInit(): void {
    this.sendRequestSchemaAndData();
  }

  private sendRequestSchemaAndData() {
    forkJoin(
      this.schemaService.getSchema(this.getSchemaUrl()),
      this.crudService.getAllByFilters(this.getDataUrl())
    ).subscribe(x => {
      this.loadSchema(x[0]);
      this.loadData(x[1]);
      this.isLoaded = true;
    });
  }

  private loadSchema(schemaGrid: Grid) {
    this.schema = schemaGrid;
  }

  private loadData(data: any) {
    this.data = data;
  }

  filtersChanged($event: IFilter[]) {
    this.crudService.getAllByFilters(this.getDataUrl(), $event).subscribe(x => {
      this.loadData(x);
    });
  }

  rowDeleteEvent($event: number) {
    this.crudService.delete(this.getDataUpdateUrl(), $event).subscribe(x => {
      this.sendRequestSchemaAndData();
    });
  }
}
