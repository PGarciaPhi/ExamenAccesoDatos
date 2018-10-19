# ExamenAccesoDatos
Examen de acceso a datos del curso de .NET

## 1. Describe las diferencias entre IQueryable<T> e IEnumerable<T>.
IQueryable<T> permite realizar consultas a un origen de datos concreto donde el tipo de datos no está especificado. Utiliza expressions LINQ a SQL, por lo que se manejan los datos relacionales que obtenemos como objetos.
Mientras que IEnumerable<T> representa un cursor de avance enumerado (iterator); es decir, representa un cursor que puede recorrer una estructura independientemente de cómo sea ésta. Utiliza LINQ a Objetos, es decir, que los objetos que capture la consulta serán cargados en memoria desde la base de datos.

## 2. Dada la siguientes estructuras de datos. Escribe con Linq los valores de a que no están en b. Escribe el mismo código con sql pensando que a y b son dos tablas de una bb.dd. y los valores están en la columna Id

## 3.  Escribe el código necesario para que un método devuelva: 1. Los pares de una secuencia de enteros de longitud indeterminada 2. Los mayores de 10 de dicha secuencia. 3. Los menores de 10 de dicha secuencia.

## 4. Una vez escrito el código del ejercicio anterior obtén el Máximo de los valores utilizando LINQ.

## 5. Describe los objetos basicos de ADO.NET y su funcionalidad.
ADO.NET consta de nueve objetos básicos:
- Connection. Proporciona una conexión para comunicarse con una fuente de datos. Sería el equivalente a una conexión de red real con el servidor de base de datos.
- Command. Representa un comando específico en forma de consulta a una fuente de datos.
- Recordset. Permite manejar registros de una tabla o resultados de un comando.
- Parameter. Representa un parámetro o argumento asociado a un comando (Command), basado en una consulta parametrizada.
- Stream. Representa un flujo de datos binarios o texto. Se puede utilizar para manipular campos o registros que contienen dichas secuencias de datos.
- Record. Permite manejar un registro obtenido desde una base de datos.
- Field. Representa una columna de datos con un tipo de datos común.
- Property. Contiene información perteneciente a una propiedad de un objeto.
- Error. Contiene detalles sobre los errores de acceso de datos que puede recibir una operación con objetos de ADO.

## 6. Escribe con lambda una función capaz de sumar dos números y multiplicarlos, una vez escrito con lambda hacer lo mismo con un método.
