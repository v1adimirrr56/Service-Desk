import { Directive, ElementRef, EventEmitter, HostListener, Input, Output } from '@angular/core';

@Directive({
  selector: '[appOutside]'
})
export class OutsideDirective {
  @Output() outsideEvent = new EventEmitter<boolean>();
  @HostListener('document:click', ['$event'])
  clickOutside(event) {
    if (!this.elementRef.nativeElement.contains(event.target))
        this.outsideEvent.emit(false);
  }
  constructor(private elementRef: ElementRef) { }

}
