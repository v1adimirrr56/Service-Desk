import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppSvgComponent } from './app-svg.component';

@NgModule({
  declarations: [
    AppSvgComponent
  ],
  exports: [
    AppSvgComponent
  ],
  imports: [
    CommonModule
  ]
})
export class SvgModule { }
