import { Component, OnInit } from '@angular/core';
import { ContactService } from '../../app/contact.service';
import { Contact } from '../../app/contact.model';


@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrl: './contacts.component.css'
})
export class ContactsComponent implements OnInit {
  randomContact!: Contact;
  searchQuery: string = '';
  constructor(private contactService: ContactService) {

  }

  ngOnInit(): void {
    this.getRandomContact();
  }

  getRandomContact(): void {
    this.contactService.getRandomContact().subscribe(
      (data) => {
        this.randomContact = data;
        console.log(this.randomContact);
      },
      (error) => {
        console.error('Error fetching random contact:', error);
      });
  }

  searchContact(): void {
    this.contactService.searchContactByName(this.searchQuery).subscribe(
      (data) => {
        this.randomContact = data;
        console.log(this.randomContact);
    },
      (error) => {
        console.error('Error fetching contact by name:', error);
      }
    );
  }
}
