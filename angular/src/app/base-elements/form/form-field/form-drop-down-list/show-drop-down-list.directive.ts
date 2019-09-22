import {
  Directive,
  EventEmitter,
  HostListener,
  Input,
  OnInit,
  Output,
  Renderer2,
  TemplateRef,
  ViewContainerRef
} from '@angular/core';

@Directive({
  selector: '[appShowDropDownList]'
})
export class ShowDropDownListDirective {
  @Output() tabKeyEvent = new EventEmitter<boolean>();

  @HostListener('keydown', ['$event']) appShowDropDownList(event) {
    console.log(event.code === 'Tab')
    if (event)
      this.tabKeyEvent.emit(true);
  }

}
