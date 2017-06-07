import {BaseModel} from './base.model';
import {Dependencia} from './dependencia.model';
import {Espacio} from './espacio.model';
import {EstadoReserva} from './estado.model';
import {Hora} from './helpers.model';
import {Injectable} from '@angular/core';


@Injectable()
export class Reserva extends BaseModel {
    constructor() {
        super();
        this.Dependencia = new Dependencia();
        this.HoraInicio = new Hora();
        this.HoraFin = new Hora();
        this.Espacio = new Espacio();
        this.Estado = new EstadoReserva();
    }

    public Dependencia: Dependencia; 
    public HoraInicio: Hora; 
    public HoraFin: Hora; 
    public Espacio: Espacio;        
    public Fecha: Date; 
    public Solicita: string; 
    public Responsable: string; 
    public Actividad: string; 
    public Email: string; 
    public Observacion: string; 
    public Estado: EstadoReserva;
    public CreationDate: Date; 
}