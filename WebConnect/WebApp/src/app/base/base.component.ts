import {Headers} from '@angular/http';
import {Observable} from 'rxjs/Rx';
import {BaseModel} from '../models/base.model';
import 'rxjs/add/operator/map';

export abstract class BaseComponent<T extends BaseModel> {
       
    public objList: Array<T>;
    public selectedObj: T;
  
    protected errorHandler(error: any) {        
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }

    public toDate(date: string): Date{        
        return new Date(parseInt(date.substr(6)));
    }

    // public invoke(module:string, method:string)  {
    //     let obj = {};
    //     let service = this.getService(module, method); 
    //     let x = this._http.get(service, this.getHeaders())
    //                       .map((r:Response) => r.json());
    //                       //.catch(this.errorHandler);
    //                     //  .toPromise()
    //                     //  .then(this.resultService)
    //                     //  .catch(this.errorHandler);
                        
    //     console.log(service);
    //     console.log(x);
    //     x.subscribe(data => obj = data);
    //     return obj;
    // }    
}