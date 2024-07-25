using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class SistemaRegistro
{
    public static int TotalRegistros = 0;
    public static void Registrar()
    {
        TotalRegistros++;
    }
    public static void MostrarTotalRegistros()
    {
        Console.WriteLine($"Total de registros: {TotalRegistros}");
    }
}