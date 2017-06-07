import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {BaseService} from '../base/base.service';
import {Reserva} from '../models/reserva.model';
import {Observable} from 'rxjs/Rx';
import {MethodType} from '../helpers/method.helper';
import {Filter} from '../helpers/filter.helper';

@Injectable()
export class ReservaService extends BaseService<Reserva> {
    
    constructor(http: Http) { 
        super(http);        
        this.module = "ReservaService";
    }
    
    public getAll(): Observable<Array<Reserva>> {                 
        return this.invoke(MethodType.Post, "GetAll");
    }

    public getByFilter(filter: Filter): Observable<Array<Reserva>> {
        this.data = filter;        
        return this.invoke(MethodType.Post, "GetByFilter");
    }

}