import { Component } from '@angular/core';
import { appConstants } from 'app'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = appConstants.configValue1;
}
