import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PersonService } from '../../../shared/services/person.service';
import { Person } from '../../../shared/models/person.model';

@Component({
  selector: 'app-person-details',
  standalone: false,
  templateUrl: './person-details.component.html',
  styleUrl: './person-details.component.css',
})
export class PersonDetailsComponent implements OnInit {
  public person: Person | null = null;
  public personId: number = 0;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private personService: PersonService,
  ) {}

  ngOnInit() {
    this.personId = +this.route.snapshot.params['personId'];
    this.getPerson();
  }

  getPerson() {
    this.personService.getPerson(this.personId).subscribe({
      next: (result) => {
        this.person = result;
      },
      error: (msg) => {
        console.log('Error Getting Person: ', msg);
      },
    });
  }

  save() {
    if (this.person) {
      this.personService.updatePerson(this.person).subscribe({
        next: () => {
          this.router.navigate(['/persons']);
        },
        error: (msg) => {
          console.log('Error Updating Person: ', msg);
        },
      });
    }
  }
}
