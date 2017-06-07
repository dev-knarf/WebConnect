import {Injectable} from '@angular/core';
import {BaseModel} from './base.model';

@Injectable()
export class Estado extends BaseModel {    
    public Nombre: string;    
}

@Injectable()
export class EstadoReserva extends BaseModel {    
    public Nombre: string;    
}