
## Como Usar


## Instalar paquetes (entity framework)
``` Install Packages
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```
## Ejecutar las migraciones

``` Run Migration
(Solo es necesario si existen migraciones en la carpeta 'Migrations')
Add-Migration API.Models.PermisoContext 

Este comando creará la BD en la instancia local de SQL server, la cadena de conexión se puede configurar en appsettings.json
(Por defecto esta configurada como trusted)


update-database

```

Ejecutar en https://localhost:44365/