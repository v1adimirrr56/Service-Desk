import { ComponentFactoryResolver, Directive, Input, OnInit, ViewContainerRef } from '@angular/core';
import { FormField } from './models/FormField';
import { FormGroup } from '@angular/forms';
import { FieldType } from './models/FieldType';
import { FormInputComponent } from './form-input/form-input.component';
import { FormCheckboxComponent } from './form-checkbox/form-checkbox.component';
import { FormDatePickerComponent } from './form-date-picker/form-date-picker.component';
import { FormDropDownListComponent } from './form-drop-down-list/form-drop-down-list.component';
import { FormRadioComponent } from './form-radio/form-radio.component';

const mappingFromFormTypeToFormComponent = {
  [FieldType.Input]: FormInputComponent,
  [FieldType.Checkbox]: FormCheckboxComponent,
  [FieldType.DatePicker]: FormDatePickerComponent,
  [FieldType.DropDownList]: FormDropDownListComponent,
  [FieldType.Radio]: FormRadioComponent
};
@Directive({
  selector: '[appDynamicFormField]'
})
export class DynamicFormFieldDirective implements OnInit {
  @Input() formField: FormField;
  @Input() group: FormGroup;
  component;

  constructor(
    private resolver: ComponentFactoryResolver,
    private container: ViewContainerRef
  ) {

  }

  ngOnInit(): void {
    const component = mappingFromFormTypeToFormComponent[this.formField.type];
    if (!this.formField.showProperties.hidden) {
      const factory = this.resolver.resolveComponentFactory<any>(component);
      this.component = this.container.createComponent(factory);
      this.component.instance.formField = this.formField;
      this.component.instance.group = this.group;
    }
  }

}
