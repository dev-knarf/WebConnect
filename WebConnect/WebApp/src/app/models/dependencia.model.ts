import {TipoDependencia, ClaseDependencia} from './helpers.model';
import {Estado} from './estado.model';
import {BaseModel} from './base.model';
import {Injectable} from '@angular/core';

@Injectable()
export class Dependencia extends BaseModel {    

    constructor(nombre?: string) {
        super();
        this.Tipo = new TipoDependencia();
        this.Clase = new ClaseDependencia();
        this.Estado = new Estado();
        if(nombre) this.Nombre = nombre;
    }    

    public Nombre: string;
    public Tipo: TipoDependencia;
    public Clase: ClaseDependencia;
    public Estado: Estado;    
}