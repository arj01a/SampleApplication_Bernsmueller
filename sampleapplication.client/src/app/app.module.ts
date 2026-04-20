import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AccountComponent } from './components/features/account/account.component';
import { PersonComponent } from './components/features/person/person.component';
import { PersonDetailsComponent } from './components/features/person-details/person-details.component';

@NgModule({
  declarations: [
    AppComponent,
    AccountComponent,
    PersonComponent,
    PersonDetailsComponent,
  ],
  imports: [BrowserModule, HttpClientModule, FormsModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
