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


@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    TabComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BaseElementsModule,
    FormModule
  ],
  providers: [SchemaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
