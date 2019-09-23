import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Grid, IFilter } from '../Grid';


@Component({
  selector: 'app-grid-builder',
  templateUrl: './grid-builder.component.html',
  styleUrls: ['./grid-builder.component.sass']
})
export class GridBuilderComponent implements OnInit {
  @Input() schema: Grid;
  @Input() data: any[];
  @Output() inputValueChanged = new EventEmitter<IFilter[]>();
  filter;
  inputValue;
  keys;

  ngOnInit(): void {
    this.keys = this.schema.columns.map(x => x.key);
  }

  changeInputValue($event: Event) {
    this.filter =
  }
}
