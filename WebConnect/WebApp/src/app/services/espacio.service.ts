import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {BaseService} from '../base/base.service';
import {Espacio} from '../models/espacio.model';
import {Observable} from 'rxjs/Rx';
import {MethodType} from '../helpers/method.helper';

@Injectable()
export class EspacioService extends BaseService<Espacio> {
    
    constructor(http: Http) { 
        super(http);        
        this.module = "EspacioService";
    }
    
    public getAll (): Observable<Array<Espacio>> {         
        return this.invoke(MethodType.Get, "GetAll");
    }    
}