import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './views/admin/dashboard/dashboard.component';
import { AdminComponent } from './layouts/admin/admin.component';
import { AdminNavbarComponent } from './components/navbars/admin-navbar/admin-navbar.component';
import { HeaderStatsComponent } from './components/headers/header-stats/header-stats.component';
import { FooterAdminComponent } from './components/footers/footer-admin/footer-admin.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { UserDropdownComponent } from './components/dropdowns/user-dropdown/user-dropdown.component';
import { NotificationDropdownComponent } from './components/dropdowns/notification-dropdown/notification-dropdown.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    AdminComponent,
    AdminNavbarComponent,
    HeaderStatsComponent,
    FooterAdminComponent,
    SidebarComponent,
    UserDropdownComponent,
    NotificationDropdownComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
