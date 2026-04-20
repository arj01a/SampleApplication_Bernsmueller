import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountComponent } from './components/features/account/account.component';
import { PersonComponent } from './components/features/person/person.component';
import { PersonDetailsComponent } from './components/features/person-details/person-details.component';

const routes: Routes = [
  { path: '', redirectTo: 'accounts', pathMatch: 'full' },
  {
    path: 'accounts',
    component: AccountComponent,
  },
  {
    path: 'persons/:personId',
    component: PersonDetailsComponent,
  },
  {
    path: 'persons',
    component: PersonComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
