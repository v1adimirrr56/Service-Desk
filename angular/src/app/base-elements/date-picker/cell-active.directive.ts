import {
  AfterViewChecked,
  AfterViewInit, ChangeDetectorRef,
  Directive,
  ElementRef,
  Input, QueryList,
  Renderer2,
} from '@angular/core';

@Directive({
  selector: '[appCellActive]'
})
export class CellActiveDirective implements AfterViewInit, AfterViewChecked {
  constructor(
    private element: ElementRef,
    private cd: ChangeDetectorRef,
    private renderer: Renderer2) {

  }

  selectedDayCell: ElementRef;

  @Input() set selectCell(value: ElementRef) {
    if (!value || !this.allCells) {
      return;
    }

    const currentActiveCell = this.allCells
      .find(x => x.nativeElement.classList.contains('datepicker__days__body__row__cell_active'));
    if (currentActiveCell) {
      this.renderer.removeClass(currentActiveCell.nativeElement, 'datepicker__days__body__row__cell_active');
    }
    this.renderer.addClass(value, 'datepicker__days__body__row__cell_active');
    this.selectedDayCell = value;
  }

  get selectCell() {
    return this.selectedDayCell;
  }

  @Input() allCells: QueryList<ElementRef>;
  @Input() initialDate;

  ngAfterViewInit() {
    this.cd.detectChanges();
  }

  ngAfterViewChecked(): void {
  }
}
