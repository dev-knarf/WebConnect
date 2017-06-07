import {Component, Input} from '@angular/core';
import {BaseComponent} from '../../base/base.component';
import {Reserva} from '../../models/reserva.model';

@Component({
    selector: 'ver-reserva',
    templateUrl: '../../components/reservas/ver-reserva.component.html'
})
export class VerReservaComponent extends BaseComponent<Reserva> {
    @Input()
    public objReserva: Reserva;

    public closeModal(): void {
        this.objReserva = null;        
    }

}