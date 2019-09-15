import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, OnInit, QueryList, ViewChildren } from '@angular/core';

@Component({
  selector: 'app-date-picker',
  templateUrl: './date-picker.component.html',
  styleUrls: ['./date-picker.component.sass']
})
export class DatePickerComponent implements OnInit, AfterViewInit {
  today = new Date();
  currentDate = this.today;
  daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wen', 'Thu', 'Fri', 'Sat'];
  months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
  calendarMatrix;
  selectedCell;
  chosenDate = new Date();
  initialDate = new Date();
  @ViewChildren('cellDay') cellsDay: QueryList<ElementRef>;

  constructor(private cd: ChangeDetectorRef) {

  }
  ngOnInit(): void {
    this.calendarMatrix = this.getMatrixDays();
  }

  ngAfterViewInit() {
    this.cd.detectChanges();
  }

  getCurrentMonth() {
    return this.months[this.currentDate.getMonth()];
  }

  getCurrentYear() {
    return this.currentDate.getFullYear();
  }

  checkActiveDate(day) {
    if (day === this.chosenDate.getDate()
      && this.currentDate.getMonth() === this.chosenDate.getMonth()
      && this.currentDate.getFullYear() === this.chosenDate.getFullYear()) {
      return true;
    }

    return false;
  }

  previousClick() {
    this.currentDate.setMonth(this.currentDate.getMonth() - 1);
    this.calendarMatrix = this.getMatrixDays();
  }

  nextClick() {
    this.currentDate.setMonth(this.currentDate.getMonth() + 1);
    this.calendarMatrix = this.getMatrixDays();
  }

  selectDay(cellDay, day) {
    this.selectedCell = cellDay;
    this.chosenDate = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), day);
  }

  clickMonth() {

  }

  getMatrixDays() {
    const previousMonthLastDay = this
      .getDaysInMonth(this.currentDate.getMonth() - 1);

    const currentFirstDayOfWeek = new Date(
      this.currentDate.getFullYear(),
      this.currentDate.getMonth(),
      1
    ).getDay();

    const currentLastDayOfWeek = new Date(
      this.currentDate.getFullYear(),
      this.currentDate.getMonth(),
      this.getDaysInMonth(this.currentDate.getMonth())
    ).getDay();
    const calendarMatrix = [];
    const allDaysForCurrentMonth = this.getAllDaysForCurrentMonth();

    for (let i = currentFirstDayOfWeek,
           prevLastDay = previousMonthLastDay; i > 0; i--, prevLastDay--) {
      allDaysForCurrentMonth.unshift(prevLastDay);
    }

    for (let i = currentLastDayOfWeek + 1,
           day = 1; i < 7; i++, day++) {
      allDaysForCurrentMonth.push(day);
    }

    for (let i = 0; i < 5; i++) {
      calendarMatrix[i] = [];
      for (let j = 0; j < 7; j++) {
        calendarMatrix[i][j] = allDaysForCurrentMonth[i * 7 + j];
      }
    }
    return calendarMatrix;
  }

  getDaysInMonth(month) {
    return new Date(
      this.currentDate.getFullYear(),
      month + 1,
      0
    ).getDate();
  }

  getAllDaysForCurrentMonth() {
    const daysInMonthCount = this.getDaysInMonth(this.currentDate.getMonth());
    const daysInMonth = [];
    for (let i = 1; i <= daysInMonthCount; i++) {
      daysInMonth.push(i);
    }
    return daysInMonth;
  }

}
