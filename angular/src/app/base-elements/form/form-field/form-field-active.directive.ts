import { Directive, ElementRef, EventEmitter, HostBinding, HostListener, Input, Output } from '@angular/core';
import { FormFieldState } from './models/FormFieldState';

@Directive({
  selector: '[appFormFieldActive]'
})
export class FormFieldActiveDirective {

  constructor(private elementRef: ElementRef) {

  }

  @Input() formFieldActive: FormFieldState;
  @Output() formFieldActiveChange = new EventEmitter<FormFieldState>();

  @HostListener('focus') onFocus() {
    this.formFieldActiveChange.emit({
      isActive: true,
      isFillUp: false
    });
  }

  @HostListener('focusout') onFocusout() {
    if (this.elementRef.nativeElement.value) {
      this.formFieldActiveChange.emit({
        isActive: false,
        isFillUp: true
      });
    } else {
      this.formFieldActiveChange.emit({
        isActive: false,
        isFillUp: false
      });
    }
  }
}
