import {Injectable} from '@angular/core';

@Injectable()
export class Filter {

    constructor(startDate?: Date, endDate?: Date) {
        this.ByDate = new DateType(startDate, endDate);                        
    }

    public ByDate: DateType;
    public ByDependencia: number = 0;
    public ByEspacio: number = 0;

    public setStartDate(date: Date): void {
        this.ByDate.StartDate = `/Date(${date.getTime()})/`;        
    }

    public setEndDate(date: Date): void {
        this.ByDate.EndDate = `/Date(${date.getTime()})/`;        
    }

}

@Injectable()
export class DateType {

    constructor(startDate?: Date, endDate?: Date) {        
        this.StartDate = startDate ? this.setStartDate(startDate) : this.setStartDate(new Date());
        this.EndDate = endDate ? this.setEndDate(endDate) : this.setEndDate(new Date());         
    }

    public Type: number = 0;
    public StartDate: string;
    public EndDate: string;

    private setStartDate(date: Date): string {
        this.StartDate = "/Date("+date.getTime()+")/";        
        return this.StartDate;
    }

    private setEndDate(date: Date): string {
        this.EndDate = "/Date("+date.getTime()+")/";
        return this.EndDate;
    }

}