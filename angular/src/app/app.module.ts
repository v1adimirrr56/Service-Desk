import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LayoutComponent } from './layout/layout.component';
import { SchemaService } from './services/schema.service';
import { TabComponent } from './tab/tab.component';
import { CreateIncidentComponent } from './incident/create-incident/create-incident.component';
import { ViewIncidentGridComponent } from './incident/view-incident-grid/view-incident-grid.component';
import { EditIncidentComponent } from './incident/edit-incident/edit-incident.component';
import { FormModule } from './base-elements/form/form.module';
import { GridModule } from './base-elements/grid/grid.module';

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
    FormModule,
    GridModule
  ],
  providers: [SchemaService],
  exports: [

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
