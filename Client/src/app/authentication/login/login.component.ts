
import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/Shared/Services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm = {
    username: "Djawed",
    password: "123456**-"
  }
  /**
   *
   */
  constructor(private authService: AuthService) {
  }
  ngOnInit(): void {
  }
  login() {
    this.authService.login(this.loginForm);
  }

}
