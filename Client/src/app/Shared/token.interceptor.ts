import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // Get the token from localStorage
        const token = localStorage.getItem('token');

        // Clone the request and add the token to the header if it exists
        if (token) {
            const authReq = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${token}`
                }
            });

            // Pass the modified request to the next interceptor or the HttpClient
            return next.handle(authReq);
        }

        // If the token does not exist, pass the original request as is
        return next.handle(request);
    }
}
