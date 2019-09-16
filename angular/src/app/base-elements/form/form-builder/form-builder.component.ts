import { ChangeDetectorRef, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SchemaService } from '../../../services/schema.service';
import { first } from 'rxjs/operators';
import { FormField } from '../form-field/models/FormField';
import { FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { FormGroupFields } from '../form-field/models/FormGroupFields';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.sass']
})
export class FormBuilderComponent implements OnInit {
  isLoaded = false;
  schema: FormField[];
  group: FormGroup;

  @Input() schemaUrl;
  @Output() submitForm = new EventEmitter<any>();

  constructor(
    private schemaService: SchemaService,
    private fb: FormBuilder) {
  }

  buildFormControl(formFields: FormField[]) {
    const group = this.fb.group({});
    formFields.forEach(x => {
      group.addControl(x.nameField, this.fb.control('', []));
    });
    this.group = group;
  }

  private addValidators(formField: FormField): ValidatorFn[] {
    const validations = [];
    if (formField.validations.required !== null && formField.validations.required !== undefined)
      validations.push(Validators.required);
    if (formField.validations.max)
      validations.push(Validators.max(formField.validations.max));
    if (formField.validations.min)
      validations.push(Validators.min(formField.validations.min));
    if (formField.validations.maxLength)
      validations.push(Validators.maxLength(formField.validations.maxLength));
    if (formField.validations.minLength)
      validations.push(Validators.minLength(formField.validations.minLength));

    return validations;
  }

  ngOnInit(): void {
    this.schemaService.getSchema(this.schemaUrl)
      .pipe(first())
      .subscribe(x => {
        this.schema = x;
        this.buildFormControl(this.schema);
        this.isLoaded = true;
      });
  }
}
