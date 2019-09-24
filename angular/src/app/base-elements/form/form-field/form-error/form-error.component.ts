import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-form-error',
  templateUrl: './form-error.component.html',
  styleUrls: ['./form-error.component.sass']
})
export class FormErrorComponent implements OnInit {
  @Input() appFormControl;
  @Input() set valueChanged(value) {

  }

  constructor() { }

  ngOnInit() {
  }
}
