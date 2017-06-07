import {Http, Response, Headers, RequestOptions} from '@angular/http';
import {Observable} from 'rxjs/Rx';
import {MethodType} from '../helpers/method.helper';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';


export abstract class BaseService<T> {
    
    private _url: string = "http://localhost:60056/Siades";

    protected module: string;
    protected http: Http;
    protected data: any = null;

    constructor(_http: Http){
        this.http = _http;
    }

    public getService(module: string, method: string): string {
        //Using interpolation of string in this method
        return `${this._url}/${module}/${method}`;
    }

    public getHeaders(): Headers {
        let header = new Headers();
        header.append('Content-Type', 'application/json');
        header.append('Accept', 'application/json');        
        return header;
    }

    public getRequestOptions(): RequestOptions{
        return new RequestOptions({headers: this.getHeaders()});
    }

    protected errorHandler(error: Response) {        
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }   
    
    protected invoke<TObj>(methodType: MethodType, methodName: string): Observable<TObj> {
        let service =  this.getService(this.module, methodName);        
        return methodType == MethodType.Get ? this.invokeGetMethod(service) : this.invokePostMethod(service);        
    } 

    protected invokeGetMethod<TObj>(endpoint: string): Observable<TObj> {
        let value = this.http.get(endpoint)
                             .map((r: Response) => r.json())
                             .catch(this.errorHandler);                             
        return value;        
    }

    protected invokePostMethod<TObj>(endpoint: string): Observable<TObj> {
        let value;        
        if(this.data != null) {    
            this.data = JSON.stringify(this.data);
            // console.log(this.data);            
            value = this.http.post(endpoint, this.data, this.getRequestOptions())
                             .map((r: Response) => r.json())
                             .catch(this.errorHandler);
            
        } else {            
            value = this.http.post(endpoint, "", this.getRequestOptions())
                             .map((r: Response) => r.json())
                             .catch(this.errorHandler);        
        }
        return value;
    }

    public getUrl(): string {
        return this._url;
    }

    public abstract getAll(): Observable<Array<T>>
        
}