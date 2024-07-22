using POO_staticEjercicios.Models;

Console.Clear();

//Ejercicio 1
Console.WriteLine("----------------Ejercicio 1----------------");
Contador.Incrementar();

//Ejercicio 2
Console.WriteLine("----------------Ejercicio 2----------------");
Convertidor.Celsius = 25;
Convertidor.CelsiusAFarenheit();

//Ejercicio 3
Console.WriteLine("----------------Ejercicio 3----------------");
Configuracion.CambiarModo();

//Ejercicio 4
Console.WriteLine("----------------Ejercicio 4----------------");
MatematicaUtil matematica = new MatematicaUtil { Numero1 = 5, Numero2 = 7 };
Console.WriteLine($"Suma: {matematica.Sumar()}");
Console.WriteLine($"Resta: {matematica.Restar()}");
Console.WriteLine($"Multiplicación: {matematica.Multiplicar()}");
Console.WriteLine($"División: {matematica.Dividir():F2}");

//Ejercicio 5
Console.WriteLine("----------------Ejercicio 5----------------");
CalculadoraAritmetica.Numero1=4;
CalculadoraAritmetica.Numero2=5;
CalculadoraAritmetica.Sumar();
CalculadoraAritmetica.Restar();
CalculadoraAritmetica.Multiplicar();
CalculadoraAritmetica.Dividir();