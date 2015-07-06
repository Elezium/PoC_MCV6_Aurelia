import {inject} from "aurelia-framework";
import {LanguageService} from "./services/LanguageService";

@inject(LanguageService)

export class App {

	constructor(LanguageService) {
		this.languageService = LanguageService;
	}

	activate()
	{
		return this.languageService
                   .getAll()
                   .then(languages => this.languages = languages);                    		
	}
}