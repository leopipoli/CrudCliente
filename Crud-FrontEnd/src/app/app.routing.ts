import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./componentes/home/home.component";
import { ListaClientesComponent } from "./componentes/lista-clientes/lista-clientes.component";
import { EditarClientesComponent } from "./componentes/editar-clientes/editar-clientes.component";




const app_routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'home', component: HomeComponent },
    { path: 'lista-clientes', component: ListaClientesComponent },
    { path: 'editar-clientes', component: EditarClientesComponent }
];

@NgModule({
    declarations: [],
    imports: [RouterModule.forRoot(app_routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}