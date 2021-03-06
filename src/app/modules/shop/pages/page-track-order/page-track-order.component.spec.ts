import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { PageTrackOrderComponent } from './page-track-order.component';

describe('PageTrackOrderComponent', () => {
    let component: PageTrackOrderComponent;
    let fixture: ComponentFixture<PageTrackOrderComponent>;

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [ PageTrackOrderComponent ],
        })
            .compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(PageTrackOrderComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
