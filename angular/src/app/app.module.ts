import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LayoutComponent } from './layout/layout.component';
import { SchemaService } from './services/schema.service';
import { TabComponent } from './tab/tab.component';
import { FormModule } from './base-elements/form/form.module';
import { BaseElementsModule } from './base-elements/base-elements.module';
import { CreateIncidentComponent } from './incident/create-incident/create-incident.component';
import { ViewIncidentGridComponent } from './incident/view-incident-grid/view-incident-grid.component';
import { EditIncidentComponent } from './incident/edit-incident/edit-incident.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    TabComponent,
    CreateIncidentComponent,
    ViewIncidentGridComponent,
    EditIncidentComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BaseElementsModule,
    FormModule
  ],
  providers: [SchemaService],
  exports: [

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
