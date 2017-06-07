import {Injectable} from '@angular/core';
import {BaseModel} from './base.model';

@Injectable()
export class TipoDependencia extends BaseModel {    
    public Nombre: string;
}

@Injectable()
export class ClaseDependencia extends BaseModel {    
    public Nombre: string;    
}

@Injectable()
export class TipoSala extends BaseModel {    
    public Nombre: string;    
}

@Injectable()
export class Hora extends BaseModel {    
    public Tiempo: string;    
}