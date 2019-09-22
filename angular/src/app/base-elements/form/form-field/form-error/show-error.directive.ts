import { AfterViewChecked, Directive, ElementRef, Input, OnDestroy, OnInit, Renderer2 } from '@angular/core';
import { AnimationBuilder, AnimationFactory, AnimationPlayer } from '@angular/animations';
import { showErrorIn, showErrorOut } from './animation';
import { NoInputRenameRule } from 'codelyzer';

@Directive({
  selector: '[appShowError]'
})
export class ShowErrorDirective implements OnInit, OnDestroy {
  private factoryShowInAnimation: AnimationFactory;
  private factoryShowOutAnimation: AnimationFactory;
  private player: AnimationPlayer;
  private player2: AnimationPlayer;
  constructor(private elementRef: ElementRef,
              private renderer: Renderer2,
              private builder: AnimationBuilder)
  {
    this.factoryShowInAnimation = this.builder.build(showErrorIn);
    this.factoryShowOutAnimation = this.builder.build(showErrorOut);
  }

  ngOnInit(): void {
    this.player = this.factoryShowInAnimation.create(this.elementRef.nativeElement);
    this.player.play();
  }

  ngOnDestroy(): void {
    this.player2 = this.factoryShowOutAnimation.create(this.elementRef.nativeElement);
    this.player2.play();
  }

}
