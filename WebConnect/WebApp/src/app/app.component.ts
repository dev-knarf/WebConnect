import {Component, OnInit} from '@angular/core';
import {Dependencia} from './models/dependencia.model';
import {Espacio} from './models/espacio.model';
import {Reserva} from './models/reserva.model';
import {BaseComponent} from './base/base.component';
import {DependenciaService} from './services/dependencia.service';
import {EspacioService} from './services/espacio.service';
import {ReservaService} from './services/reserva.service';
import {BaseModel} from './models/base.model';
import {Filter} from './helpers/filter.helper';

@Component({
  selector: 'app-root',  
  templateUrl: './app.component.html',  
  styles: ['.separator {height: 10px}'],
  providers: [DependenciaService, EspacioService, ReservaService]  
})
export class AppComponent extends BaseComponent<Reserva> implements OnInit {
    
    protected titulo: string = 'Reservas';
        
    protected filtroFecha: number = 0;

    protected depList: Array<Dependencia> = new Array<Dependencia>();
    protected selectedDep: Dependencia;

    protected espList: Array<Espacio> = new Array<Espacio>();
    protected selectedEsp: Espacio;

    protected filter: Filter;    
    protected fechaIni: Date = new Date();
    protected fechaFin: Date = new Date();
    protected optBetween: boolean = false;

    constructor(private _depService: DependenciaService,
                private _espService: EspacioService,
                private _resService: ReservaService) { super(); }

    protected getAll(): void {
        this.depList.push(new Dependencia("Seleccione una dependencia"));
        this._depService.getAll()
                        .subscribe((data: Array<Dependencia>) => data.forEach(d => this.depList.push(d)),
                                    error => console.log(error));         
        //--
        this.espList.push(new Espacio("Seleccione un espacio"));                                           
        this._espService.getAll()
                        .subscribe((data: Array<Espacio>) => data.forEach(d => this.espList.push(d)),
                                    error => console.log(error));        
        //--
        // console.log("filtroFecha " + this.filtroFecha); 
        
        this.filter = new Filter(this.fechaIni, this.fechaFin);
        this.filter.ByDate.Type = this.filtroFecha;  
        // console.log(JSON.stringify(this.filter) );      
        this._resService.getByFilter(this.filter)
                        .subscribe((data: Array<Reserva>) => this.objList = data,
                                    error => console.log(error));                                    
    }    

    public ngOnInit(): void {                
        this.getAll();        
        this.selectedDep = this.depList[0];
        this.selectedEsp = this.espList[0];
    }
   
    protected buscarReserva(): void {            
        this.filter = new Filter(new Date(this.fechaIni), new Date(this.fechaFin));
        this.filter.ByDate.Type = this.filtroFecha;
        this.filter.ByDependencia = this.selectedDep.ObjectId;        
        this.filter.ByEspacio = this.selectedEsp.ObjectId;          
        //--
        this._resService.getByFilter(this.filter)
                        .subscribe((data: Array<Reserva>) => this.objList = data,
                                    error => console.log(error));    
    }

    protected selectDateChange(): void {
        this.optBetween = this.filtroFecha == 3 ? true : false;        
    }   

    // public depChange(objectId: number): void {         
    //     if(objectId == 0)
    //         this.selectedDep = new Dependencia();
    //     else            
    //         this.selectedDep = this.depList.filter(item => item.ObjectId == objectId)[0];
    // }   

    // public espChange(objectId: number): void {         
    //     if(objectId == 0)
    //         this.selectedEsp = new Espacio();
    //     else            
    //         this.selectedEsp = this.espList.filter(item => item.ObjectId == objectId)[0];
    // }   

    // public selectObject(obj: any, fill: string): void {                
    //     //console.log("FRANK: " + this.selectedDep.Nombre);
    //     // switch(fill){
    //     //     case "esp":
    //     //         let objId: number = (<Espacio> obj).ObjectId;
    //     //         console.log("FRANK: " + objId);
    //     //         if(obj.ObjectId == 0)
    //     //             this.selectedEsp = new Espacio();
    //     //         else            
    //     //             this.selectedEsp = this.espList.filter(item => item.ObjectId == obj.ObjectId)[0];
    //     //     case "dep":
    //     //         if(obj.ObjectId == 0)
    //     //             this.selectedDep = new Dependencia();
    //     //         else            
    //     //             this.selectedDep = this.depList.filter(item => item.ObjectId == obj.ObjectId)[0];        
    //     // }        
    // }   

    // public filtroFechaChange(filtroId: number): void {        
    //     this.filtroFecha = filtroId;        
    // }   

    // public viewObject(objectId: number): void {
    //     if(objectId == 0)
    //         this.selectedObj = new Reserva();
    //     else            
    //         this.selectedObj = this.objList.filter(item => item.ObjectId == objectId)[0];
    // }
}