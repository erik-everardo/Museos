# Leeme
Este es el código del proyecto de base de datos. Es una aplicación hecha en .NET 6 y Windows Forms. Estamos utilizando Entity Framework Core (un ORM) para acceder a nuestra base de datos, que es SQLite.

* Instalar Visual Studio: https://visualstudio.microsoft.com/es/vs/
* Instructivo de los paquetes: https://docs.microsoft.com/en-us/ef/core/what-is-new/nuget-packages
* Instructivo del DbContext: https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/
* Instructivo de modelos: https://docs.microsoft.com/en-us/ef/core/modeling/
* DbBrowser for SQlite: https://sqlitebrowser.org/dl/

## El código

Hasta este momento, se tiene ya configurado Entity Framework Core, eso incluye las referencias a los paquetes necesarios y el DbContext de nuestra app. 

* En la carpeta [Tablas](Museos/Tablas) están las clases que representan las entidades
* El archivo [AppDbContext](Museos/AppDbContext.cs) es el contexto de base de datos. En el se encuentra los DbSet de cada entidad, que representan las tablas (que aqui son colecciones de objetos, que representan las tuplas que vienen y van de la base de datos). Cuando queramos usar esta clase, es necesario crear una instancia de la forma tradicional (con new)
```c#
// ejemplo para leer los comentarios de la obra con id 2

// primero hago una instancia de mi contexto de base de datos
var database = new AppDbContext()


// luego hago el query utilizando Linq

// Estoy llamando a ToList() para terminar la operacion y no siga siendo un query
var comentariosObra2 = database.Comentarios.Where(comentario => comentario.ObraId == 2).ToList()

```

## Migraciones
Cuando hagamos un cambio en las clases es necesario hacer una migración. Para ello se utiliza `dotnet ef Migrations Add InitialMigration`, donde InitialMigration es el nombre de la migracion que queremos crear (puede ser cualquier nombre, sin espacios).

Despues de que hagamos una migración, es necesario actualizar la base de datos. Para ello se utiliza el comando `dotnet ef Database Update`, que escribirá los cambios de la ultima migración. Es posible que falle, pues algunas cosas no pueden ser cambiadas (por ejemplo eliminar una columna que ya tiene datos, cambiar el nombre, etc.). Si falla, lo más facil es borrar el archivo .db y borrar todo el contenido de Migrations y volver a crear una migración.

## Aqui dejo un video de la configuración.
[![Proyecto de Base de datos. 1. Configuración Entity Framework Core](https://img.youtube.com/vi/5eYTvWp_-W8/0.jpg)](https://www.youtube.com/watch?v=5eYTvWp_-W8)

## Aquí videos del progreso
* Creacion de ventanas admin y launcher: https://www.youtube.com/watch?v=TIC-X4BE7Uw
