import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AuthenticationModule } from './authentication/authentication.module';
import { ToastrModule } from 'ngx-toastr';
import { TokenInterceptor } from './Shared/token.interceptor';
import { SharedModule } from './Shared/shared.module';
import { AuthService } from './Shared/Services/auth.service';
import { appInitializer, appSettingsInitializer } from './Shared/app-initializer';
import { SettingService } from './Shared/Services/setting.service';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AuthenticationModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
    SharedModule
  ],
  exports: [],
  providers: [SettingService,
    {
      provide: APP_INITIALIZER,
      useFactory: appSettingsInitializer,
      deps: [SettingService],
      multi: true
    },
    AuthService,
    {
      provide: APP_INITIALIZER,
      useFactory: appInitializer,
      deps: [AuthService],
      multi: true
    }, {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
