import { Component, OnInit } from '@angular/core';
import { FormContainerComponent } from '../../base-elements/form/form-container/form-container.component';
import { getContext } from '@angular/core/src/render3/discovery_utils';


@Component({
  selector: 'app-edit-incident',
  templateUrl: '../../base-elements/form/form-container/form-container.component.html',
  styleUrls: ['./edit-incident.component.sass']
})
export class EditIncidentComponent extends FormContainerComponent implements OnInit {
  isCreate = false;
  getContext() {
    return 'Incidents';
  }

  getSchema() {
    return 'IncidentDto';
  }

  getData() {
    return 'Incidents';
  }
  ngOnInit(): void {
    super.ngOnInit();
  }
}
