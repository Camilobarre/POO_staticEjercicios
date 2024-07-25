using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class Usuario
{
    public static int TotalUsuarios = 0;

    public Usuario()
    {
        TotalUsuarios++;
    }
    
    public static void MostrarTotalUsuarios()
    {
        Console.WriteLine($"Total de usuarios creados: {TotalUsuarios}");
    }
}