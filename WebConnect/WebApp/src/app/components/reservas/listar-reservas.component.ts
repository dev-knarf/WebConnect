import {Component, Input} from '@angular/core';
import {BaseComponent} from '../../base/base.component';
import {Reserva} from '../../models/reserva.model';

@Component({
    selector: 'listar-reservas',
    templateUrl: '../../components/reservas/listar-reservas.component.html',
    styles: [
        '.align-vm {vertical-align: middle}',
        '.width-col-10 {width: 10%}',
        '.width-col-20 {width: 20%}'
    ]
})
export class ListarReservasComponent extends BaseComponent<Reserva> {
    @Input()
    public listarReservas: Array<Reserva>;

    public selectedObj: Reserva;

    public viewDetails(obj: Reserva): void {        
        this.selectedObj = obj;
    }
}