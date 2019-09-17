import {
  Component,
  ElementRef,
  HostListener,
  Renderer2,
  ViewChild
} from '@angular/core';
import { FormInputComponent } from '../form-input/form-input.component';

@Component({
  selector: 'app-form-drop-down-list',
  templateUrl: './form-drop-down-list.component.html',
  styleUrls: ['./form-drop-down-list.component.sass']
})
export class FormDropDownListComponent extends FormInputComponent {
  isShow;
  inputValue;
  @ViewChild('input') input: FormInputComponent;

  @HostListener('document:click', ['$event']) appShowDropDownList(event) {
    if (!this.elementRef.nativeElement.children[0].contains(event.target)) {
      this.isShow = false;
      this.input.forceFocus = false;
    }
  }

  constructor(private elementRef: ElementRef, private renderer: Renderer2) {
    super();
  }

  chooseOption(label: string) {
    this.group.get(this.formField.nameField).setValue(label);
    this.inputValue = label;
    this.input.forceFocus = false;
    this.isShow = false;
  }

  focusChangeEvent($event) {
    if ($event) {
      this.input.forceFocus = $event;
      this.isShow = $event;
    }
  }

  tabKeyEventHandler($event: boolean) {
    this.input.forceFocus = false;
    this.isShow = false;
  }
}
