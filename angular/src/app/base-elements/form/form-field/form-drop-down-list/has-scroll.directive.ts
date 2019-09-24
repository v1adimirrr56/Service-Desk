import { Directive, ElementRef, Input, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appHasScroll]'
})
export class HasScrollDirective implements OnInit {
  @Input('appHasScroll') options;
  constructor(private elementRef: ElementRef,
              private  renderer: Renderer2) {

  }

  ngOnInit(): void {
    if (this.options.length > 4)
      this.renderer.addClass(this.elementRef.nativeElement, 'hasScroll');
  }

}
