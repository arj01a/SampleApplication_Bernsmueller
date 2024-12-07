import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Account } from '../models/account.model';
import { catchError, Observable, retry } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class AccountService {

  webApiUrl = "https://localhost:7131"
 
  constructor(private http: HttpClient) {}
 
  getAccounts(): Observable<Account[]> {
    return this.http.get<Account[]>(this.webApiUrl + '/Account').pipe(retry(2));
  }
}
