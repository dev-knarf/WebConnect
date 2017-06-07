import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {BaseService} from '../base/base.service';
import {Dependencia} from '../models/dependencia.model';
import {Observable} from 'rxjs/Rx';
import {MethodType} from '../helpers/method.helper';

@Injectable()
export class DependenciaService extends BaseService<Dependencia> {
    
    constructor(http: Http) { 
        super(http);        
        this.module = "DependenciaService";
    }
    
    public getAll (): Observable<Array<Dependencia>> {     
        return this.invoke(MethodType.Get, "GetAll");
    }    
}