import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'project',
    templateUrl: './project.component.html'
})
export class ProjectComponent {
    public projects: Project[];
    public customers: Customer[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Customer').subscribe(result => {
            this.customers = result.json() as Customer[];
        }, error => console.error(error));

        http.get(baseUrl + 'api/Project/FindByCustomer').subscribe(result => {
            this.projects = result.json() as Project[];
        }, error => console.error(error));
    }
}

interface Project {
    id: number;
    name: string;
    customerID: number;
}

interface Customer {
    id: number;
    name: string;
}
