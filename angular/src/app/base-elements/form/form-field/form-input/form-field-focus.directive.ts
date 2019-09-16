import { Directive, ElementRef, EventEmitter, HostListener, Input, Output } from '@angular/core';
import { AnimationBuilder, AnimationFactory, AnimationPlayer } from '@angular/animations';
import { formFieldInputfocusAnimation, formFieldInputfocusoutAnimation } from './animations/form-input-animation';

@Directive({
  selector: '[appFormFieldFocus]'
})
export class FormFieldFocusDirective {
  private factoryFocusAnimation: AnimationFactory;
  private factoryFocusoutAnimation: AnimationFactory;
  private player: AnimationPlayer;

  constructor(
    private elementRef: ElementRef,
    private builder: AnimationBuilder
  ) {
    this.factoryFocusAnimation = builder.build(formFieldInputfocusAnimation);
    this.factoryFocusoutAnimation = builder.build(formFieldInputfocusoutAnimation);
  }

  isActive: boolean;
  @HostListener('focus') focus() {
    if (!this.isActive) {
      this.isActive = !this.isActive;
      this.appFormFieldFocusChange.emit(this.isActive);
    }
  }

  @HostListener('focusout') focusout() {
    if (this.isActive && !this.forceActive) {
      this.isActive = !this.isActive;
      this.appFormFieldFocusChange.emit(this.isActive);
    }
  }

  @Input('appFormFieldFocus') set setIsActive(value) {
    if (value) {
      this.player = this.factoryFocusAnimation.create(this.elementRef.nativeElement);
    } else {
      this.player = this.factoryFocusoutAnimation.create(this.elementRef.nativeElement);
    }

    this.player.play();
    this.isActive = value;
  }

  @HostListener('document:click', ['$event']) documentClick(event) {
    if (!this.elementRef.nativeElement.contains(event.target) && !this.forceActive) {
      this.isActive = false;
      this.appFormFieldFocusChange.emit(this.isActive);
    }
  }
  @Input() forceActive;
  @Output() appFormFieldFocusChange = new EventEmitter<boolean>();

}
