import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { ViewIncidentGridComponent } from './incident/view-incident-grid/view-incident-grid.component';
import { CreateIncidentComponent } from './incident/create-incident/create-incident.component';
import { TabComponent } from './tab/tab.component';
import { EditIncidentComponent } from './incident/edit-incident/edit-incident.component';


const incidentRoutes: Routes = [
  { path: '', component: ViewIncidentGridComponent},
  { path: 'create-incident', component: CreateIncidentComponent},
  { path: 'edit-incident/:id', component: EditIncidentComponent},
  { path: 'view-incidents', component: ViewIncidentGridComponent}
];

const tabRoutes: Routes = [
  { path: '', component: TabComponent, children: incidentRoutes},
];

const routes: Routes = [
  { path: '', component: LayoutComponent, children: tabRoutes }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
