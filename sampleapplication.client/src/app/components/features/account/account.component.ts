import { Component, OnInit } from '@angular/core';
import { AccountService } from '../../../shared/services/account.service';
import { Account } from '../../../shared/models/account.model';

@Component({
  selector: 'app-account',
  standalone: false,
  templateUrl: './account.component.html',
  styleUrl: './account.component.css'
})
export class AccountComponent implements OnInit {

  public accounts: Account[] = [];

  constructor(private accountService: AccountService) {}

  ngOnInit() {
    this.getAccounts();
  }

  getAccounts(){
    this.accountService.getAccounts().subscribe({
      next: (result) =>  {
        this.accounts = result;
    },
    error: (msg) => {
        console.log('Error Getting Accounts: ', msg);
    }
   });
  }

}
