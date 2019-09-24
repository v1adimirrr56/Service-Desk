import { Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { Grid, IFilter } from '../Grid';
import { Subject, timer } from 'rxjs';
import { debounce } from 'rxjs/operators';
import { Router } from '@angular/router';


@Component({
  selector: 'app-grid-builder',
  templateUrl: './grid-builder.component.html',
  styleUrls: ['./grid-builder.component.sass']
})
export class GridBuilderComponent implements OnInit, OnDestroy {
  @Input() schema: Grid;
  @Input() data: any[];
  @Output() filtersChanged = new EventEmitter<IFilter[]>();
  @Output() rowDeleteEvent = new EventEmitter<number>();
  debounceFilterChanged: Subject<IFilter[]> = new Subject();
  statusValue;
  stateValue;
  keys;
  filters: IFilter[];

  constructor(private router: Router) {
    this.debounceFilterChanged.pipe(
      debounce(x => timer(500))
    ).subscribe(x => {
      this.filtersChanged.emit(x);
    });
  }


  ngOnInit(): void {
    this.keys = this.schema.columns.map(x => x.key);
    this.filters = [
      {
        propertyName: 'StateName',
        value: ''
      },
      {
        propertyName: 'StatusName',
        value: ''
      }
    ];
  }

  changeInputValue(nameField, value) {
    this.filters = this.filters.map(x => {
      if (x.propertyName === nameField)
        return { propertyName: x.propertyName, value };
      return { propertyName: x.propertyName, value: x.value };
    });

    this.debounceFilterChanged.next(this.filters);
  }

  ngOnDestroy(): void {
    this.debounceFilterChanged.unsubscribe();
  }

  createNavigate() {
    this.router.navigateByUrl('/create-incident');
  }

  editNavigate(id: number) {
    this.router.navigateByUrl(`/edit-incident/${id}`);
  }

  deleteRow(id: number) {
    this.rowDeleteEvent.emit(id);
  }
}
