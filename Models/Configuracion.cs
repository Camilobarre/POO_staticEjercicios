using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class Configuracion
{
    public static bool ModoOscuro { get; set; }
    public static bool ModoOscuroCambiar { get; set; }
    public static void CambiarModo()
    {
        ModoOscuro = false;
        Console.WriteLine($"Modo: {ModoOscuro}");
        Console.WriteLine("Modo oscuro activado");
        ModoOscuroCambiar = true;
        Console.WriteLine($"Modo: {ModoOscuroCambiar}");
        Console.WriteLine("Modo oscuro desactivado");
    }
}