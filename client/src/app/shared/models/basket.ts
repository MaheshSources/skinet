// import { v4 as uuidv4 } from 'uuid';
import * as uuid from 'uuid';


import { ObjectUnsubscribedError } from 'rxjs';

export interface IBasket {
  id: string;
  items: IBasketItem[];
}


export interface IBasketItem {
  id: number;
  productName: string;
  price: number;
  quantity: number;
  pictureUrl: string;
  brand: string;
  type: string;
}


export class Basket implements IBasket{

  id = uuid.v4();

  items: IBasketItem[] = [];

  constructor() {
  console.log('id allocated is ::' && this.id);

  }
}


export interface IBasketTotals {
  shipping: number;
  subtotal: number;
  total: number;
}
