import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { FormatIdPipe } from './helpers/number.helper';
import { ListarReservasComponent } from './components/reservas/listar-reservas.component';
import { VerReservaComponent } from './components/reservas/ver-reserva.component';

@NgModule({
  declarations: [
    AppComponent,
    FormatIdPipe,
    VerReservaComponent,
    ListarReservasComponent    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],  
  bootstrap: [AppComponent]
})
export class AppModule { }
