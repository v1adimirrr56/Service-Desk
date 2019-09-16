import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateDatepickerComponent } from './base-elements/date-picker/create-datepicker/create-datepicker.component';
import { TabComponent } from './tab/tab.component';
import { LayoutComponent } from './layout/layout.component';

const routes: Routes = [
  { path: 'datepicker', component: CreateDatepickerComponent },
  { path: '', component: LayoutComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
