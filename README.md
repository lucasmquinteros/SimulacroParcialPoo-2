Caso 1:
Pregunta 1: Si, porque si no aplico persistencia,
	cada vez que el sistema se perderia la informacion sobre que clase esta disponible y cual no esta disponible.

Pregunta 2: Si, podria usar un diccionario para guardar cada miembro,
	Aunque no es la unica opcion, tambien se podria usar otro tipo de coleccion como lista.

Caso 2:
Pregunta 1: Si, es necesario implementar encapsulamiento ya que cualquier persona 
	que tenga acceso al sistema, pondria en riesgo la integridad de los datos al cometer un error, o perder datos importantes como el historial clinico

Pregunta 2: No, los dueños no son reelevantes en el sistema, ya que aunque guarde los dueños no tendria forma de relacionarlo a su mascota
	o forma de identificarlo.

Caso 3:	
Pregunta 1: Si, aunque no infiera en el precio,
	 debe haber alguna forma de diferenciar el turno de una cancha de futbol o de tenis



Pregunta 2: No, una cola seria mas util	al administrar los turnos por horarios
	el primer socio en reservar sera quien use la cancha, el segundo socio que haya reservado debera esperar a que el primero termine

Caso 4:
/*Si los libros son unicos*/
Pregunta 1: No, seria mas eficiente utilizar un diccionario donde el libro es la llave y el usuario es el valor
	ya que en el sistema no especifica que haya mas de 1 ejemplar por libro, cada libro es unico dentro de esta libreria
/*Si cada libro tiene mas de un ejemplar*/
Pregunta 1: Seria mas eficiente utilizar una lista de usuarios, dentro de estos una lista de libros que tenga
	 en este caso el sistema utilizado podria mutar para otro caso especifico. Guardo cada usuario dentro del sistema para conocer quien tiene el libro

Pregunta 2: Si, Necesito guardar que libro esta prestado o disponible, y en caso que este prestado
	A quien fue prestado.

Bonus: 
Una interfaz es un contrato donde especifico METODOS qué las clases que hereden de mi interfaz requieran implementar si o si los metodos
Una clase abstracta es una generalizacion de PROPIEDADES y METODOS, que todas las clases que hereden de una abstracta deberan implementar los metodos y propiedades pasadas por el constructor.
En ambas clases no se pueden crear instancias, a menos que otras clases hereden de ellas.
La diferencia esta en la utilizacion entre ellas, incluso en una clase abstracta puedo crear metodos que podre llamar en las clases heredadas, en una interfaz no puedo crear codigo dentro de los metodos.

Practica: 
SISTEMA <- CRUD - ListaVideoJuegos | Archivo.txt
VideoJuego <- Nombre | Plataforma | Precio | CantidadStock
Plataforma : PlayStatios, Xbox, PC 
