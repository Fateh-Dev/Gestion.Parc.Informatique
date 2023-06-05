import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, map } from 'rxjs';
import { AppStoreService } from './app-store.service';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

export interface Settings {
  id: number;
  structureId: string;
  description: string;
  appName: string;
  strcutureChildren: string[];

  // Other Settings properties
}
@Injectable({
  providedIn: 'root'
})
export class SettingService {
  private apiUrl = 'https://localhost:8000';

  private appSettingsSubject: BehaviorSubject<Settings>;
  public appSettings$: Observable<Settings>;

  constructor(private http: HttpClient,
    public toastr: ToastrService, public appStoreService: AppStoreService,
    private router: Router) {
    // Initialize the appSettingsSubject with an initial value of null
    this.appSettingsSubject = new BehaviorSubject<Settings>({} as Settings);
    this.appSettings$ = this.appSettingsSubject.asObservable();
    // Check if token exists in local storage upon AuthService initialization
    this.loadappSettings();
  }

  loadappSettings() {
    this.appStoreService.loadSettings().subscribe(
      (e: Settings) => { this.appSettingsSubject.next(e) },
      () => this.appSettingsSubject.next({} as Settings)
    );

  }

  // Method to set the current Settings
  setappSettings(set: Settings): void {
    this.appSettingsSubject.next(set);
  }

  // Method to get the current Settings
  getappSettings(): Settings {
    return this.appSettingsSubject.value;
  }

}
