import {Pipe, PipeTransform} from '@angular/core';

@Pipe({name: 'formatId'})
export class FormatIdPipe implements PipeTransform {

    public transform(value: number, l: number): string {        
        let n: string = value + "";
        return Array(l - (n.length - 1)).join("0") + n;
    }
}