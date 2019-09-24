import { Component, OnInit } from '@angular/core';
import { FormContainerComponent } from '../../base-elements/form/form-container/form-container.component';

@Component({
  selector: 'app-create-incident',
  templateUrl: '../../base-elements/form/form-container/form-container.component.html',
  styleUrls: ['./create-incident.component.sass']
})
export class CreateIncidentComponent extends FormContainerComponent implements OnInit {
  isCreate = true;
  getContext() {
    return 'Incidents';
  }

  getSchema() {
    return 'IncidentDto';
  }

  getData() {
    return 'Incidents';
  }
}
