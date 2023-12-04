import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'
import { Contact } from '../app/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private url = 'https://randomuser.me/api/';

  constructor(private http: HttpClient) { }

  getRandomContact(): Observable<Contact> {
    //return this.http.get<Contact>(`${this.url}/contact/randomcontact`);
    return this.http.get<Contact>(`${this.url}/`);
  }

  searchContactByName(name: string): Observable<Contact> {
    //return this.http.get<Contact>(`${this.url}/contact/searchcontact?name=${name}`);
    return this.http.get<Contact>(`${this.url}/?name=${name}`);
  }
}
