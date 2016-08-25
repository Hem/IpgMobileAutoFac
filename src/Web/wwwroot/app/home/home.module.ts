﻿import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { HomeComponent } from './home.component'; 


@NgModule({
    imports: [BrowserModule],
    declarations: [HomeComponent],
    bootstrap: [HomeComponent]
})
export class HomeModule { }


// Bootstrap module here!!!
// This way we can include the module on every page...
platformBrowserDynamic().bootstrapModule(HomeModule);