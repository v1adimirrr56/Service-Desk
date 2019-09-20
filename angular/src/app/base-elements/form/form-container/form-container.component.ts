import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-container',
  templateUrl: './form-container.component.html'
})
export class FormContainerComponent implements OnInit {
  protected getSchema() {}
  protected getContext() {}
  protected getData() {}
  private schemaUrl() {
    return `${this.getContext()}/${this.getSchema()}`;
  }

  private dataUrl() {
    return `${this.getData()}`;
  }

  constructor() { }

  ngOnInit() {
  }

  submitData($event) {
    console.log($event);
  }

}
