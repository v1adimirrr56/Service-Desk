import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormField } from '../form-field/models/FormField';
import { FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { SchemaService } from '../../../services/schema.service';
import { CrudService } from '../../../services/crud.service';
import { forkJoin } from 'rxjs';
import { MarkAsTouched } from '../form-builder/form-extensions';

@Component({
  selector: 'app-form-container',
  templateUrl: './form-container.component.html'
})
export abstract class FormContainerComponent implements OnInit {
  @Output() submitForm = new EventEmitter<any>();
  isLoaded = false;
  schema: FormField[];
  group: FormGroup;
  data: any;

  protected abstract getSchema();

  protected abstract getContext();

  protected abstract getData();

  private getSchemaUrl() {
    return `${this.getContext()}/${this.getSchema()}`;
  }

  private getDataUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }

  private getDataUpdateUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }


  constructor(
    private schemaService: SchemaService,
    private crudService: CrudService,
    private fb: FormBuilder) {
  }

  ngOnInit(): void {
    forkJoin(
      this.schemaService.getSchema(this.getSchemaUrl()),
      this.crudService.get(this.getDataUrl(), 1)
    ).subscribe(x => {
      this.loadSchema(x[0]);
      this.loadData(x[1]);
      const controlKeys = Object.keys(this.group.controls);
      controlKeys.forEach(y => {
        this.group.controls[y].setValue(this.data[y]);
      });
      this.isLoaded = true;
    });
  }

  buildFormControl(formFields: FormField[]) {
    const group = this.fb.group({});
    formFields.forEach(x => {
      group.addControl(
        x.nameField,
        new FormControl(
          {disabled: x.showProperties.readOnly},
          this.addValidators(x)
        )
      );
    });
    this.group = group;
  }

  private addValidators(formField: FormField): ValidatorFn[] {
    const validations = [];
    if (formField.validations.required) {
      validations.push(Validators.required);
    }
    if (formField.validations.max) {
      validations.push(Validators.max(formField.validations.max));
    }
    if (formField.validations.min) {
      validations.push(Validators.min(formField.validations.min));
    }
    if (formField.validations.maxLength) {
      validations.push(Validators.maxLength(formField.validations.maxLength));
    }
    if (formField.validations.minLength) {
      validations.push(Validators.minLength(formField.validations.minLength));
    }
    if (formField.validations.regExp) {
      validations.push(Validators.pattern(formField.validations.regExp));
    }

    return validations;
  }

  loadData(data: any) {
    this.data = data;
  }

  loadSchema(formFields: FormField[]) {
    this.schema = formFields;
    this.buildFormControl(this.schema);
  }

  submit($event) {
    this.crudService.post(this.getDataUpdateUrl(), $event.value).subscribe(x => {
    }, response => {
      if (Array.isArray(response.error)) {
        const errors = response.error as IApiError[];
        errors.forEach(error => {
          error.memberNames.forEach(member => {
            if (!this.group.controls[member].errors.fromApi)
              this.group.controls[member].setErrors({ fromApi: error.errorMessage });
          });
        });
        MarkAsTouched(this.group);
      }
    });
  }

}

interface IApiError {
  memberNames: string[];
  errorMessage: string;
}
