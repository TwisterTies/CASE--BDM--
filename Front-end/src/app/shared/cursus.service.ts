import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cursus } from './cursus.model';

@Injectable({
  providedIn: 'root'
})
export class CursusService {

  constructor(private http: HttpClient) { }
  readonly baseURL = `https://localhost:44386/api/cursus`;
  formData: Cursus = new Cursus();
  list: Cursus[];

  postCursussen() {
    return this.http.post(this.baseURL, this.formData)
  }

  refreshCursusLijst() {
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as Cursus[]);
  }
}
