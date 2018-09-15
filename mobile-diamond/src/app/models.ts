import { HttpHeaders } from "@angular/common/http";


export class number {  //
    id: string
    name: string
    
}




export class GlobalVarible {
    static host: string = "https://localhost:5001/";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })  //
    };

    

}

