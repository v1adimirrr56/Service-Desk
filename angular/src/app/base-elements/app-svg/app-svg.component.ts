import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-svg',
  templateUrl: './app-svg.component.html',
  styleUrls: ['./app-svg.component.sass']
})
export class AppSvgComponent implements OnInit {
  @Input() svgIcon;
  icon;
  constructor() { }

  ngOnInit() {
    this.icon = icons[this.svgIcon];
  }

}

const icons = {
  chevronLeft : 'M20 1 L24 5 L14 16 L24 27 L20 31 L6 16 z',
  chevronRight : 'M12 1 L26 16 L12 31 L8 27 L18 16 L8 5 z',
};
