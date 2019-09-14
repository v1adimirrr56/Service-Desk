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

  @Input() appFormFieldFocus: boolean;
  @Output() appFormFieldFocusChange = new EventEmitter<boolean>();

  @HostListener('focus') onFocus() {
    this.player = this.factoryFocusAnimation.create(this.elementRef.nativeElement);
    this.player.play();
    this.appFormFieldFocusChange.emit(true);
  }

  @HostListener('focusout') onFocusout() {
    this.player = this.factoryFocusoutAnimation.create(this.elementRef.nativeElement);
    this.player.play();
    this.appFormFieldFocusChange.emit(false);
  }
}
