import { Directive, HostListener, Input, OnInit, Renderer2, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appShowDatePicker]'
})
export class ShowDatePickerDirective implements OnInit {
  isShow = false;
  @Input('appShowDatePicker') set toggle(value: boolean) {
    if (value) {
      this.viewContainer.createEmbeddedView(this.templateRef);
    } else {
      this.viewContainer.clear();
    }
    this.isShow = value;
  }

  constructor(
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef) { }

  ngOnInit(): void {

  }

}
