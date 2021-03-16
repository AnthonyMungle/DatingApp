import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({ //Decorator giving the class the component ability
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating app'; //Used for string Interpolation
  users: any; //Any turns off type safety NOT BEST PRActice 

  constructor(private http: HttpClient){} //Dependency Injection

  ngOnInit() {
    this.getUsers();
  }

  getUsers(){
    //'Observable' If response is anything other then 200 you move to error portion
        this.http.get('https://localhost:5001/api/users').subscribe(reponse => {
        this.users = reponse;
      }, error => {
        console.log(error);
      })
  }


}
