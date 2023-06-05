import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-rest-material-table',
  templateUrl: './rest-material-table.component.html',
  styleUrls: ['./rest-material-table.component.css']
})
export class RestMaterialTableComponent implements OnInit {
  /**
   *
   */
  loading = false;
  @Input()
  _dataSource = {
    totalCount: 0,
    items: []
  };

  @Input()
  page = 1;

  @Input()
  pageSize = 20;

  constructor(public http: HttpClient) {
    this.requestApi();
  }

  title = 'Client';
  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
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
  requestApi() {
    this.loading = true;
    this.http.post<any>("https://localhost:8000/Structures/GetPagedByFilter",
      { page: this.page, pageSize: this.pageSize }).subscribe(e => {
        // console.log(e)
        this.dataSource = new MatTableDataSource<any>(e.items);
        this._dataSource = e;
        this.loading = false;
      })
  }
  next() {
    this.page = this.page + 1;
    if (this.page * this.pageSize <= this._dataSource.totalCount) {
      this.requestApi();

    } else {
      this.page = this.page - 1;
    }
  }
  previous() {

    this.page = this.page - 1;
    if (this.page >= 1)
      this.requestApi();
    else this.page = 0;
  }
  ngOnInit(): void {
  }
}
