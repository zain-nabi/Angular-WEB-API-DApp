import { HttpClient, HttpHeaders, JsonpClientBackend } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Member } from '../_models/member';

/*const httpOptions = {
  headers: new HttpHeaders({
    Authorization: 'Bearer ' + JSON.parse(localStorage.getItem('user'))?.token
  })
}*/

@Injectable({
  providedIn: 'root'
})
export class MembersService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getMembers(){
    return this.http.get<Member[]>(this.baseUrl+ 'ApplicationUser')
  }

  getMember(username: string){
    return this.http.get<Member>(this.baseUrl+ 'ApplicationUser/' + username)
  }

  updateMember(member: Member){
    return this.http.put(this.baseUrl + 'ApplicationUser', member);
  }
}
