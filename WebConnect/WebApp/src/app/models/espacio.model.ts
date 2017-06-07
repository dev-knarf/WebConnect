import {TipoSala} from './helpers.model';
import {BaseModel} from './base.model';
import {Estado} from './estado.model';
import {Injectable} from '@angular/core';

@Injectable()
export class Espacio extends BaseModel {

    constructor(nombre?: string) {
        super();
        this.Tipo = new TipoSala();
        this.Estado = new Estado();
        if(nombre) this.Nombre = nombre;
    }

    public Nombre: string 
    public Capacidad: number 
    public Descripcion: string
    public Tipo: TipoSala 
    public Estado: Estado      
}