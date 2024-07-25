using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class UtilidadCadena
{
    public static string Reverso(string cadena)
    {
        if (cadena == null)
        {
            Console.WriteLine("La cadena no puede ser nula");
        }
        char[] array = cadena.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}