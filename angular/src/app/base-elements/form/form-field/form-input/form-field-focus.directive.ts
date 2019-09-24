import { Directive, EventEmitter, HostListener, Output } from '@angular/core';

@Directive({
  selector: '[appFormFieldFocus]'
})
export class FormFieldFocusDirective {

  @Output() appFormFieldFocusChanged = new EventEmitter();
  @HostListener('focus') focus() {
      this.appFormFieldFocusChanged.emit(true);
  }

  @HostListener('blur') focusout() {
      this.appFormFieldFocusChanged.emit(false);
  }
}
