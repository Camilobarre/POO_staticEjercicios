using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class BaseDatos
{
    public static string Conexion;
    static BaseDatos()
    {
        Conexion = "Conexión a la base de datos establecida.";
    }
    public static void MostrarConexion()
    {
        Console.WriteLine(Conexion);
    }
}