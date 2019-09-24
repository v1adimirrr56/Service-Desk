import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GridBuilderComponent } from './grid-builder/grid-builder.component';
import { GridContainerComponent } from './grid-container/grid-container.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    GridBuilderComponent,
    GridContainerComponent
  ],
  exports: [
    GridBuilderComponent,
    GridContainerComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ]
})
export class GridModule { }
