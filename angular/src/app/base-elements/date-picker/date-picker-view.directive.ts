import { Directive, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appDatePickerView]'
})
export class DatePickerViewDirective {

  constructor(private template: TemplateRef<object>,
              private container: ViewContainerRef) { }

}
