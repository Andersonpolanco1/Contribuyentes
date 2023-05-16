# Contribuyentes

En este repositorio se encuentran dos proyectos:

- ContribuyentesApi
- ContribuyentesUI

## ContribuyentesApi
El proyecto ContribuyentesApi es un proyecto en el cual se pueden hacer consultas de contribuyentes y sus respectivas facturas fiscales a la API con algunos datos que se generan al ejecutar las migraciones, 
esta desarrollado con .NET Core 6 y Visual Studio 2022. En el mismo se utiliza SqlServer para la persistencia de los datos.

Para correr este proyecto, despues de clonarlo, si desea utilizar SQL Server solo actualize la cadena de conexión por defecto en el archivo ``Program.cs`` en la capa web (ContribuyentesApi.Web)
de lo contrario debera configurar su motor de base de datos deseado, luego ejecute el comando ``dotnet ef database update`` para ejecutar las migraciones que creará la base de datos, las tablas y generará algunos registros.

### Endpoints

- Todos los contribuyentes:  ``https://localhost:7291/api/contribuyentes``
- Buscar un contribuyente por Rnc o Cédula: ``https://localhost:7291/api/contribuyentes?rncCedula=123456789``
- Todos los comprobantes fiscales:  ``https://localhost:7291/api/contribuyentes/comprobantes``
- Buscar comprobantes fiscales por Rnc o Cédula: ``https://localhost:7291/api/contribuyentes/comprobantes?rncCedula=123456789``

El proyecto está dividido en 4 capas:

- ContribuyentesApi.Web: Capa en la que crearemos nuestros controladores y proveerá acceso mediante el protocolo HTTP.

- ContribuyentesApi.Core: La capa central de la API, conteniendo todas las interfaces de nuestros servicios y repositorios y tambien todas las entidades (clases) centrales.

- ContribuyentesApi.Services: Esta capa es donde centraremos toda nuestra logica de negocios y validaciones.

- ContribuyentesApi.Infrastructure: Es la encargada de tener todo lo referido al acceso a datos y administrar la base de datos.

El proyecto ContribuyentesApi.Test es para las pruebas unitarias.

## ContribuyentesUI
Este proyecto corresponde a la presentacion del proyecto de contribuyentes. Fue creado con el framework Angular en su version 15 y Visual Studio Code.
Para correr este proyecto, debe tener la version ya mencionada de Angular y tener corriendo el primer proyecto (ContribuyentesApi) ya que carga una lista de contribuyentes
desde el momento que inicia.

El proyecto tiene una pantalla principal para la vista de contribuyentes y otra pantalla en la cual, al seleccionar un contribuyente se obtiene un listado de facturas fiscales que ha reportado el mismo.

### Imagenes de los proyectos corriendo
#### Pantallas del proyecto ContribuyentesUI:

- Lista de contribuyentes:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/index.JPG)

- Lista de comprobantes fiscales de un contribuyente:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/comprobantes-contirbuyente.JPG)

- Lista de comprobantes fiscales de un contribuyente:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/comprobantes-contirbuyente.JPG)

#### Imagenes de respuesta de la API


- Todos los contribuyentes:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/contribuyentesapi-todos.JPG)

- Busqueda de contribuyente por NCF o cédula:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/contribuyentesapi-uno.JPG)

- Todos los comprobantes fiscales:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/comprobantes-todos.JPG)

- Comprobantes fiscales por NCF o cédula:
![Alt](https://github.com/Andersonpolanco1/Contribuyentes/blob/develop/imagenes/comprobantes-uno.JPG)






