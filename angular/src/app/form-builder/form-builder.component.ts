import { AfterViewChecked, ChangeDetectorRef, Component } from '@angular/core';
import { SchemaService } from '../services/schema.service';

@Component({
  selector: 'app-form-builder',
  templateUrl: './form-builder.component.html',
  styleUrls: ['./form-builder.component.sass']
})
export class FormBuilderComponent implements AfterViewChecked {
  isLoaded = false;

  constructor(private cdRef: ChangeDetectorRef, private schemaService: SchemaService) {
    this.schemaService.getSchema('incidents', 'incident')
      .subscribe(x => {
        this.isLoaded = true;
      });
  }

  ngAfterViewChecked(): void {
  }
}
