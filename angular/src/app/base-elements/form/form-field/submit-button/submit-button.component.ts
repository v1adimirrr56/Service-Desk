import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-submit-button',
  templateUrl: './submit-button.component.html',
  styleUrls: ['./submit-button.component.sass']
})
export class SubmitButtonComponent implements OnInit {
  @Input() group;

  ngOnInit() {
  }

}
