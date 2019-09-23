import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormField } from '../form-field/models/FormField';
import { FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { SchemaService } from '../../../services/schema.service';
import { CrudService } from '../../../services/crud.service';
import { forkJoin } from 'rxjs';
import { MarkAsTouched } from '../form-builder/form-extensions';
import { SchemaBuilder } from '../../models/Schema-builder';

@Component({
  selector: 'app-form-container',
  templateUrl: './form-container.component.html'
})
export abstract class FormContainerComponent extends SchemaBuilder implements OnInit {
  @Output() submitForm = new EventEmitter<any>();
  isLoaded = false;
  schema: FormField[];
  group: FormGroup;
  data: any;

  private getSchemaUrl() {
    return `${this.getContext()}/${this.getSchema()}/Forms`;
  }
  private getDataUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }
  private getDataUpdateUrl() {
    return `${this.getContext()}/${this.getData()}`;
  }


  constructor(
    private schemaService: SchemaService<FormField[]>,
    private crudService: CrudService,
    private fb: FormBuilder) {
    super();
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
      // validation only ValidationResultModel
      if (Array.isArray(response.error.errors)) {
        const errors = response.error.errors as IApiError[];
        errors.forEach(error => {
          error.memberNames.forEach(member => {
            if (!this.group.controls[member].errors
              || (this.group.controls[member].errors
                && !this.group.controls[member].errors.fromApi)) {
              if (this.group.controls[`${member}label`])
                this.group.controls[`${member}label`].setErrors({fromApi: error.errorMessage});
              else
                this.group.controls[member].setErrors({fromApi: error.errorMessage});
            }
          });
        });
        MarkAsTouched(this.group);
      } else
      // default asp.net core validation
      if (response.error.errors) {
        const errorDic = response.error.errors;
        const errorKeys = Object.keys(errorDic);
        errorKeys.forEach(errorKey => {
          const errorKeyFirstLowercase = errorKey[0].toLowerCase() + errorKey.substring(1);
          if (this.group.controls[`${errorKeyFirstLowercase}label`])
            this.group.controls[`${errorKeyFirstLowercase}label`].setErrors({fromApi: errorDic[errorKey][0]});
          else
            this.group.controls[errorKeyFirstLowercase].setErrors({fromApi: errorDic[errorKey][0]});
        });
      }
    });
  }

}

interface IApiError {
  memberNames: string[];
  errorMessage: string;
}
