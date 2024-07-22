using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class Convertidor
{
    public static double Celsius { get; set; }
    public static double Farenheit { get; set; }

    public static void CelsiusAFarenheit()
    {
        Farenheit = 32 + (Celsius * 1.8);
        Console.WriteLine($"{Celsius}°C = {Farenheit}°F");
    }
}