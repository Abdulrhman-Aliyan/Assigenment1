import { Component,OnInit } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';
// import { AppComponent } from './app.component';

// @NgModule({
//   declarations: [
//     AppComponent
//   ],
//   imports: [
//     BrowserModule,
//     FormsModule,
//     HttpClientModule
//   ],
//   providers: [],
//   bootstrap: [AppComponent]
// })

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Angular';
  games : any;
  constructor(private http:HttpClient) {

  }

  ngOnInit(): void {
    this.http.get("http://localhost:5296/api/Games").subscribe(res => {
     this.games =res;
     console.log("next")
    },
    err => {console.log("error")},
    () => {console.log("Complete")}
    )
 }

}
