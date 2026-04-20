import { Component, OnInit } from '@angular/core';
import { PersonService } from '../../../shared/services/person.service';
import { Person } from '../../../shared/models/person.model';

@Component({
  selector: 'app-person',
  standalone: false,
  templateUrl: './person.component.html',
  styleUrl: './person.component.css',
})
export class PersonComponent implements OnInit {
  public persons: Person[] = [];

  constructor(private personService: PersonService) {}

  ngOnInit() {
    this.getPersons();
  }

  getPersons() {
    this.personService.getPersons().subscribe({
      next: (result) => {
        this.persons = result;
      },
      error: (msg) => {
        console.log('Error Getting Persons: ', msg);
      },
    });
  }
}
