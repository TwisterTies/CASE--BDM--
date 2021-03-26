import { Component, OnInit } from '@angular/core';
import { CursusService } from '../shared/cursus.service';

@Component({
  selector: 'alle-cursussen',
  templateUrl: './cursus.component.html',
})
export class CursusComponent implements OnInit {

  constructor(public service: CursusService) { }

  ngOnInit(): void {
    this.service.refreshCursusLijst();
  }
  

}
