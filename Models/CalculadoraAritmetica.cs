using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class CalculadoraAritmetica
{
    public static int Numero1 { get; set; }
    public static int Numero2 { get; set; }

    public static void Sumar()
    {
        int Suma = Numero1 + Numero2;
        Console.WriteLine($"Suma: {Suma}");
    }
    public static void Restar()
    {
        int Resta = Numero1 - Numero2;
        Console.WriteLine($"Suma: {Resta}");
    }
    public static void Multiplicar()
    {
        int Multiplicacion = Numero1 * Numero2;
        Console.WriteLine($"Suma: {Multiplicacion}");
    }
    public static void Dividir()
    {
        double Division = Numero1 / Numero2;
        Console.WriteLine($"Suma: {Division:F2}");
    }
}