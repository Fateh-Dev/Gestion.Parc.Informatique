import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  get NbreOfPreselection() {
    let i = 0;
    let regular = "white";
    let test = "rgb(248, 59, 59)";
    let solo = "rgb(249, 253, 18)";
    var array: string[] = [];
    for (let index = 0; index < 21; index++) {
      array.push(regular);
    }
    array[12] = test;
    array[18] = test;
    array[20] = solo;
    return array;
  }
}
