﻿﻿import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

let baseUrl = "http://localhost:54368/api/Languages/";

@inject(HttpClient)
export class LanguageService {

	constructor(httpClient) {
		this.http = httpClient;
	}

	getAll() {		
		return this.http.get(baseUrl)
                        .then(response => {                        	
                        	return response.content;
                        });
	}

}