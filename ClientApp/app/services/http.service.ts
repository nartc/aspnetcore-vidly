import { Observable } from 'rxjs/Rx';
import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class HttpService {

  constructor(private http: Http) { }

  get(endpoint: string, headersObject: Object): Observable<any> {
    const headers: Headers = new Headers(headersObject);
    const options: RequestOptions = new RequestOptions({headers: headers});
    return this.http.get(endpoint, options)
      .map((res): Promise<any> => {
        return res.json();
      });
  }

}
