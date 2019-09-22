import { ChangeDetectorRef, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { SchemaService } from '../../../services/schema.service';
import { first } from 'rxjs/operators';
import { FormField } from '../form-field/models/FormField';
import { FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { FormGroupFields } from '../form-field/models/FormGroupFields';
import { CrudService } from '../../../services/crud.service';
import { forkJoin } from 'rxjs';
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.sass']
})
export class FormBuilderComponent implements OnInit {
  isLoaded = false;
  schema: FormField[];
  schemaWithoutHidden: FormField[];
  group: FormGroup;
  data: any;

  @Input() schemaUrl;
  @Input() dataUrl;
  @Output() submitForm = new EventEmitter<any>();

  constructor(
    private schemaService: SchemaService,
    private crudService: CrudService,
    private fb: FormBuilder) {}

  buildFormControl(formFields: FormField[]) {
    const group = this.fb.group({});
    formFields.forEach(x => {
      if (x.showProperties.hidden)
        return;

      group.addControl(
        x.nameField,
        new FormControl(
          { disabled: x.showProperties.readOnly },
          this.addValidators(x)
        )
      );
    });
    this.group = group;
  }

  setSchemaWithoutHidden() {
    this.schemaWithoutHidden = this.schema.filter(x => {
      return !x.showProperties.hidden;
    });
  }

  private addValidators(formField: FormField): ValidatorFn[] {
    const validations = [];
    if (formField.validations.required !== undefined && formField.validations.required !== null)
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

  loadData(data: any) {
    this.data = data;
  }

  loadSchema(formFields: FormField[]) {
    this.schema = formFields;
    this.buildFormControl(this.schema);
  }

  ngOnInit(): void {
    forkJoin(
      this.schemaService.getSchema(this.schemaUrl),
      this.crudService.get(this.dataUrl, 1)
    ).subscribe(x => {
      this.loadSchema(x[0]);
      this.loadData(x[1]);
      this.setSchemaWithoutHidden();
      const controlKeys = Object.keys(this.group.controls);
      controlKeys.forEach(y => {
        this.group.controls[y].setValue(this.data[y]);
      });

      this.isLoaded = true;
    });
  }
}
