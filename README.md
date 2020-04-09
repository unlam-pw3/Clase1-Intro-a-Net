# Primera Clase de Práctica

En esta clase vimos:
1. Como usar el **Visual Studio 2019 Community**.
	1. Disposicion de Ventanas
	2. Como Debuggear
	3. Atajos útiles
2. Creamos una Solucion **PrimeraClase1** con los proyectos:
	1. **Aplicacion de Consola (c# .Net Framework)** llamada "PrimeraClase1"
		1. Vimos como escribir/leer en consola usando Console.ReadLine() y Console.WriteLine()
		2. Vimos como agregar una referencia a otro proyecto de Biblioteca de Clases y agregar el using correspondiente.
	2. **Bibliotecas de Clases (c# .Net Frameworkbok)** llamada "BibliotecaDeClases"
		1. Creamos la clase **Calculadora** con el método estático Sumar
		2. Vimos como convertir de string a entero con **Int.Parse()**, **Convert.ToInt32()** y **Int32.TryParse()**
	3. **Asp.Net MVC Vacio (c# .Net Framework)** llamado "AplicacionWeb"
		1. Creamos un **controller** llamado "HomeController" con un action Index y realizamos una suma utilizando la clase **Calculadora**
		2. Creamos una **vista** en /Views/Home/Index.cshtml y mostramos este resultado utilizando **ViewBag**
		3. Vimos como funciona el archivo /App_Start/**routeconfig.cs**
		4. Creamos un nuevo action Duplicar(int id) recibiendo por parametro un número (agregando en la url del browser /Home/Duplicar/90) y devolviendo su valor multiplicado por 2.
		5. Creamos su correspondiente vista en /Views/Home/Duplicar.cshtml escribiendo ambos valores utilizando ViewBag
		
# Como Ejecutar
1. Abrir el archivo PrimeraClase1.sln con el Visual Studio
2. Click derecho en la solución, Restaurar paquetes de Nuget
3. Click derecho en el proyecto que se desea ejecutar (PrimeraClase1 o AplicacionWeb), Establecer como proyecto de Inicio
4. F5