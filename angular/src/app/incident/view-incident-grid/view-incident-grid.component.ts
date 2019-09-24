import { Component, OnInit } from '@angular/core';
import { GridContainerComponent } from '../../base-elements/grid/grid-container/grid-container.component';

@Component({
  selector: 'app-view-incident-grid',
  templateUrl: '../../base-elements/grid/grid-container/grid-container.component.html',
  styleUrls: ['./view-incident-grid.component.sass']
})
export class ViewIncidentGridComponent extends GridContainerComponent {
  protected getContext() {
    return 'Incidents';
  }

  protected getData() {
    return 'IncidentsList';
  }

  protected getSchema() {
    return 'IncidentList';
  }

}
