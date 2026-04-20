import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from '../models/person.model';
import { catchError, Observable, retry } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PersonService {
  webApiUrl = 'https://localhost:7131';

  constructor(private http: HttpClient) {}

  getPersons(): Observable<Person[]> {
    return this.http.get<Person[]>(this.webApiUrl + '/Person').pipe(retry(2));
  }

  getPerson(id: number): Observable<Person> {
    return this.http
      .get<Person>(this.webApiUrl + '/Person/' + id)
      .pipe(retry(2));
  }

  updatePerson(person: Person): Observable<any> {
    return this.http.put(this.webApiUrl + '/Person', person).pipe(retry(2));
  }
}
