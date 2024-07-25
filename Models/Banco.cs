using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class Banco
{
    public static double TasaDeInteres { get; set; } = 0.05;
    public static double CalcularInteres(double capital, int periodoEnAños)
    {
        if (capital < 0 || periodoEnAños < 0)
        {
            Console.WriteLine("El capital y el periodo deben ser valores positivos.");
        }
        double interes = capital * TasaDeInteres * periodoEnAños;
        return interes;
    }
}