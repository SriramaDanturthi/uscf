import { GetBrandsOptions } from '../../app/api/base';
import { Observable, of } from 'rxjs';
import { Brand } from '../../app/interfaces/brand';
import { HttpClient } from '@angular/common/http';

export function getBrands($http: HttpClient, options?: GetBrandsOptions): Observable<Brand[]> {
    options = options || {};
    return $http.get<Brand[]>('https://localhost:5001/api/products/brands');
}
