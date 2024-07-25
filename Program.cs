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
CalculadoraAritmetica.Numero1 = 1;
CalculadoraAritmetica.Numero2 = 2;
CalculadoraAritmetica.Sumar();
CalculadoraAritmetica.Restar();
CalculadoraAritmetica.Multiplicar();
CalculadoraAritmetica.Dividir();

//Ejercicio 6
Console.WriteLine("----------------Ejercicio 6----------------");
AlmacenamientoMensajes.AgregarMensaje("Hola, este es el primer mensaje.");
AlmacenamientoMensajes.AgregarMensaje("Aquí va otro mensaje.");
AlmacenamientoMensajes.MostrarMensajes();

//Ejercicio 7
Console.WriteLine("----------------Ejercicio 7----------------");
BaseDatos.MostrarConexion();

//Ejercicio 8
Console.WriteLine("----------------Ejercicio 8----------------");
string texto = "Hola Mundo";
string textoReverso = UtilidadCadena.Reverso(texto);
Console.WriteLine($"Texto original: {texto}");
Console.WriteLine($"Texto reverso: {textoReverso}");

//Ejercicio 9
Console.WriteLine("----------------Ejercicio 9----------------");
Usuario usuario1 = new Usuario();
Usuario usuario2 = new Usuario();
Usuario usuario3 = new Usuario();
Usuario.MostrarTotalUsuarios();

//Ejercicio 10
Console.WriteLine("----------------Ejercicio 10---------------");
DateTime fecha1 = new DateTime(2024, 1, 1);
DateTime fecha2 = new DateTime(2024, 7, 1);
int diasEntre = UtilidadFecha.DiasEntreFechas(fecha1, fecha2);
Console.WriteLine($"Número de días entre {fecha1.ToShortDateString()} y {fecha2.ToShortDateString()} es: {diasEntre} días.");

//Ejercicio 11
Console.WriteLine("----------------Ejercicio 11---------------");
Banco.TasaDeInteres = 0.07;
double capital = 10000;
int periodoEnAños = 5;
double interesGanado = Banco.CalcularInteres(capital, periodoEnAños);
Console.WriteLine($"El interés ganado sobre un capital de {capital:C} durante {periodoEnAños} años a una tasa de interés del {Banco.TasaDeInteres:P} es: {interesGanado:C}");

//Ejercicio 12
Console.WriteLine("----------------Ejercicio 12---------------");
ConfiguracionApp.MostrarVersion();

//Ejercicio 13
Console.WriteLine("----------------Ejercicio 13---------------");
GestorInventario.AñadirProducto();
GestorInventario.AñadirProducto();
GestorInventario.MostrarTotalProductos();

//Ejercicio 14
Console.WriteLine("----------------Ejercicio 14---------------");
SistemaRegistro.Registrar();
SistemaRegistro.Registrar();
SistemaRegistro.Registrar();
SistemaRegistro.Registrar();
SistemaRegistro.Registrar();
SistemaRegistro.MostrarTotalRegistros();