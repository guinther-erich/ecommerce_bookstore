import { Injectable } from "@angular/core";
import { HttpClient, HttpHandler, HttpHeaders } from "@angular/common/http";
import { Book } from "./model/Book";

@Injectable()

export class BookService
{
  private url = 'https://localhost:44396/api/Bookstore';

  httpOptions = {
    Headers: new HttpHeaders({'content-type': 'application/json'})
  }

  constructor(private http:HttpClient){}

  getBook(){
    return this.http.get(this.url)
  }

}
