import { HttpHeaders } from "@angular/common/http";

export class LoanInterest {
    interestRate: number
    interest: string
    balance: number
    year: number
    totalBalance : number
}



export class GlobalVarible {
    static host: string = "https://localhost:5001";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}