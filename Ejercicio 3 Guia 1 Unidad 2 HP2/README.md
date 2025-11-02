Descripción
---------------------------------------
Aplicación en C# con Windows Forms que permite registrar, mostrar y eliminar cursos virtuales o presenciales, aplicando los patrones Factory y Singleton.

 Funcionalidad
--
Agregar cursos con nombre, docente, duración, número de estudiantes y precio.

Calcular el precio final según el tipo de curso:

Presencial: +20% si tiene más de 30 estudiantes.

Virtual: -15% si tiene más de 50 estudiantes.

Mostrar la lista de cursos registrados.

Eliminar todos los cursos registrados.

Patrones usados
--
Factory: crea objetos CursoVirtual o CursoPresencial.

Singleton: mantiene una única lista de cursos en memoria.

Clases principales
--
Cursos: clase base con atributos y CalcularPrecio().

CursoVirtual / CursoPresencial: heredan de Cursos.

CursosFactory: crea los objetos según el tipo.

GestorCursos: almacena los cursos y aplica el Singleton.

FrmSistemaCursos: interfaz del usuario.

Autor
--
Nicolle Carvajal Gómez - Ingenieria de Software - Herramientas de Programación II 

