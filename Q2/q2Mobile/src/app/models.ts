import { HttpHeaders } from "@angular/common/http";

export class Products {
    id: number
    name: string
    price: number
}

export class Carts {
    id: number
    name: string
    price: number
    numberOf: number
    balance:number
}
// export class Winner {
//     gamblers: Gambler[]
//     theNumber: number
// }

export class GlobalVarible {
    static host: string = "https://localhost:5001";

    static httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
}