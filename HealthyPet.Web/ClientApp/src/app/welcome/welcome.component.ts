import { Component, OnInit } from '@angular/core';
import * as M from 'materialize-css';

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.css']
})
export class WelcomeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    document.addEventListener('DOMContentLoaded', function () {
      const elems = document.querySelectorAll('.parallax');
      const instances = M.Parallax.init(elems);
    });
  }

}
