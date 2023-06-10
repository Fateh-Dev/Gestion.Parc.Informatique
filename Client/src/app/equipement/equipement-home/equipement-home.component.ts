import { Component } from '@angular/core';

@Component({
  selector: 'app-equipement-home',
  templateUrl: './equipement-home.component.html',
  styleUrls: ['./equipement-home.component.css']
})
export class EquipementHomeComponent {

  displayedColumns: string[] = ['Nom', 'NumSerie', 'Marque', 'position'];
  url = "https://localhost:8000/Structures/GetPagedByFilter";
}
