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

## Enlaces importantes
* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

## Ejemplos de queries
En el proyecto hay una clase que se llama `DbContextApp`. Dicha clase se encuentra en el namespace Museos, por lo que no es necesario agregar ningun `using`. Sin embargo, si es necesario agregar `using Museos.Tablas` para poder utilizar las clases de las tablas (Modelos).

Si se quiere obtener todas las obras, solo se necesita hacer lo siguiente.
```c#
// primero creo una instancia de AppDbContext.
// Esta variable puede ser de clase y privada si es necesario
private AppDbContext _db = new()

// ya que tengo mi objeto _db, puedo hacer las consultas.
// Una forma es
List<Obra> todasLasObras = _db.Obras.ToList();

// Y la otra utilizando LINQ
List<Obra> todasLasObras = (from obra in _db.Obras select obra).ToList();
```
## Aquí videos del progreso
* Creacion de ventanas admin y launcher: https://www.youtube.com/watch?v=TIC-X4BE7Uw
* Login: https://youtu.be/rrWk9X8ClBc
* Cómo clonar repositorio privado: https://youtu.be/iQcN-E-N9-M
* Dialogo para agregar info de museos: https://youtu.be/MUSxklDtAM4
* Dialogo de agregar obra y avance de lista de obras: https://youtu.be/CjtGKzX2HNE
* Guardando imagenes en la base de datos: https://www.youtube.com/watch?v=8zZZBYVPZJY
* Solución a "No se ha encontrado la tabla": https://www.youtube.com/watch?v=vz0KaWqR-bA
* Especificaciones del proyecto: https://www.youtube.com/watch?v=RTcrB2VDK9U
* Proyecto casi terminado: https://www.youtube.com/watch?v=bjNrwQ0SPfM
