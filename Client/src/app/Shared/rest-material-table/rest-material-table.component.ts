import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-rest-material-table',
  templateUrl: './rest-material-table.component.html',
  styleUrls: ['./rest-material-table.component.css']
})
export class RestMaterialTableComponent {

  loading = false;

  @Input()
  url: string = "";
  _dataSource = {
    totalCount: 0,
    items: []
  };
  @Input()
  page = 0;
  @Input()
  pageSize = 10;

  constructor(public http: HttpClient) { }

  @Input()
  displayedColumns: string[] = [];
  dataSource = new MatTableDataSource<any>(this._dataSource.items);

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  getRowColor(index: number): string {
    return index % 2 === 0 ? 'even-row' : 'odd-row';
  }
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.requestApi();
  }
  requestApi(event?: PageEvent) {
    this.loading = true;
    this.http.post<any>(this.url,
      { page: event?.pageIndex || this.page, pageSize: event?.pageSize || this.pageSize }).subscribe(e => {
        this.dataSource = new MatTableDataSource<any>(e.items);
        this._dataSource = e;
        this.loading = false;
      })
  }
  onPageChange(event: PageEvent) {
    this.requestApi(event)
  }

  // length:24 
  // pageIndex:1 
  // pageSize:10 
  // previousPageIndex:0

}
