import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-container',
  templateUrl: './form-container.component.html'
})
export class FormContainerComponent implements OnInit {
  protected getSchema() {}
  protected getContext() {}
  public schemaUrl() {
    return `${this.getContext()}/${this.getSchema()}`;
  }

  constructor() { }

  ngOnInit() {
  }

  submitData($event) {
    console.log($event);
  }

}
