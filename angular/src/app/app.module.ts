import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormBuilderComponent } from './form-builder/form-builder.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { LayoutComponent } from './layout/layout.component';
import { SchemaComponent } from './schema/schema.component';
import { SchemaService } from './services/schema.service';
import { TabComponent } from './tab/tab.component';


@NgModule({
  declarations: [
    AppComponent,
    FormBuilderComponent,
    LayoutComponent,
    TabComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SchemaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
