import { Directive, Input, OnInit, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appShowDropDownList]'
})
export class ShowDropDownListDirective implements OnInit {
  isShow: boolean;
  @Input('appShowDropDownList') set setIsShow(value) {
    if (value) {
      this.container.createEmbeddedView(this.template);
    } else {
      this.container.clear();
    }
    this.isShow = value;
  }

  constructor(private container: ViewContainerRef,
              private template: TemplateRef<object>)
  {
  }

  ngOnInit(): void {
  }

}
