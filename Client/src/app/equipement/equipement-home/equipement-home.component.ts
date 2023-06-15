import { Component, OnInit } from '@angular/core';
import { RestMaterialTableComponent } from 'src/app/Shared/rest-material-table/rest-material-table.component';

@Component({
  selector: 'app-equipement-home',
  templateUrl: './equipement-home.component.html',
  styleUrls: ['./equipement-home.component.css']
})
export class EquipementHomeComponent extends RestMaterialTableComponent implements OnInit {
  ngOnInit(): void {
    this.displayedColumns = ['Nom', 'NumSerie', 'Marque', 'Position'];
    this.url = "https://localhost:8000/Structures/GetPagedByFilter";
  }




}
