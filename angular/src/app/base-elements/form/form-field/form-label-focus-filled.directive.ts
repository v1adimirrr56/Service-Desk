import { Directive, ElementRef, EventEmitter, Input, Output } from '@angular/core';
import { AnimationBuilder, AnimationFactory, AnimationPlayer } from '@angular/animations';
import {
  filledFocusFormLabelAnimation, filledFocusoutFormLabelAnimation,
  focusFormLabelAnimation,
  focusoutFormLabelAnimation
} from './animations/form-label-animation';

@Directive({
  selector: '[appFormLabelFocusFilled]'
})
export class FormLabelFocusFilledDirective {
  private factoryFocusAnimation: AnimationFactory;
  private factoryFocusoutAnimation: AnimationFactory;
  private factoryFilledFocusAnimation: AnimationFactory;
  private factoryFilledFocusoutAnimation: AnimationFactory;
  private player: AnimationPlayer;

  constructor(
    private elementRef: ElementRef,
    private builder: AnimationBuilder
  ) {
    this.factoryFocusAnimation = builder.build(focusFormLabelAnimation);
    this.factoryFocusoutAnimation = builder.build(focusoutFormLabelAnimation);
    this.factoryFilledFocusAnimation = builder.build(filledFocusFormLabelAnimation);
    this.factoryFilledFocusoutAnimation = builder.build(filledFocusoutFormLabelAnimation);
  }

  @Input() set appFormLabelFocusFilled(isFocus: boolean) {

    if (this.inputValue) {
      if (isFocus) {
        this.player = this.factoryFilledFocusAnimation.create(this.elementRef.nativeElement);
      } else {
        this.player = this.factoryFilledFocusoutAnimation.create(this.elementRef.nativeElement);
      }
    } else {
      if (isFocus) {
        this.player = this.factoryFocusAnimation.create(this.elementRef.nativeElement);
      } else {
        this.player = this.factoryFocusoutAnimation.create(this.elementRef.nativeElement);
      }
    }
    this.player.play();
  }

  @Input() inputValue;
  @Output() appFormLabelFocusFilledChange = new EventEmitter<boolean>();
}
