import { ChangeDetectorRef, Component } from '@angular/core';
import { SchemaService } from '../../../services/schema.service';
import { first } from 'rxjs/operators';
import { FormField } from '../form-field/models/FormField';
import { FormBuilder, FormGroup } from '@angular/forms';
import { FormGroupFields } from '../form-field/models/FormGroupFields';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.sass']
})
export class FormBuilderComponent {
  isLoaded = false;
  schema: FormField[];
  group: FormGroup;

  constructor(
    private cdRef: ChangeDetectorRef,
    private schemaService: SchemaService,
    private fb: FormBuilder) {
    this.schemaService.getSchema('incidents', 'incident')
      .pipe(first())
      .subscribe(x => {
        this.schema = x;
        this.buildFormControl(this.schema);
        this.isLoaded = true;
      });
  }

  buildFormControl(formFields: FormField[]) {
    const group = this.fb.group({});
    formFields.forEach(x => {
      group.addControl(x.nameField, this.fb.control(''));
    });
    this.group = group;
  }
}
