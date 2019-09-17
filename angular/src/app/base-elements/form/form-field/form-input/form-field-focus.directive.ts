import { Directive, ElementRef, EventEmitter, HostListener, Input, Output } from '@angular/core';
import { AnimationBuilder, AnimationFactory, AnimationPlayer } from '@angular/animations';
import { formFieldInputfocusAnimation, formFieldInputfocusoutAnimation } from './animations/form-input-animation';

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
