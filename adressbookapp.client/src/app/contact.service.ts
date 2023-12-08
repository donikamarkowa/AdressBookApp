import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs'
import { Contact } from '../app/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private url = 'https://localhost:7145/api';

  constructor(private http: HttpClient) { }

  getRandomContact(): Observable<Contact> {
    return this.http.get<Contact>(`${this.url}/Contacts/randomcontact`);
  }

  searchContactByName(name: string): Observable<Contact> {
    const params = new HttpParams().set('name', name);
    return this.http.get<Contact>(`${this.url}/Contacts/searchcontact`, { params });
  }
}
