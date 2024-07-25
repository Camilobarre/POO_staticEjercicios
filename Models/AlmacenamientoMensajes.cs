using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class AlmacenamientoMensajes
{
    public static List<string> Mensajes = new List<string>();

    public static void AgregarMensaje(string mensaje)
    {
        Mensajes.Add(mensaje);
    }

    public static void MostrarMensajes()
    {
        if (Mensajes.Count == 0)
        {
            Console.WriteLine("No hay mensajes para mostrar.");
        }
        else
        {
            Console.WriteLine("Mensajes almacenados:");
            foreach (var mensaje in Mensajes)
            {
                Console.WriteLine(mensaje);
            }
        }
    }
}