import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registerForm = {
    username: "",
    password: "",
    firstName: "",
    lastName: "",
  }
  /**
   *
   */
  constructor(public http: HttpClient, public toastr: ToastrService, private router: Router) {
  }
  ngOnInit(): void {
  }
  status = 200
  register() {
    this.http.post("https://localhost:8000/Users/register", this.registerForm).subscribe(e => {
      // TODO Save Token

      this.router.navigate(['/home']);
      this.toastr.success('Authentication Success ', 'Success');
    }, e => {
      this.toastr.error('Authentication Failed', 'Error');

    })
  }

}
