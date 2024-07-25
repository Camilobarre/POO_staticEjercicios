using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class ConfiguracionApp
{
    public static string VersionApp { get; private set; }
    static ConfiguracionApp()
    {
        VersionApp = "1.0.0";
    }
    public static void MostrarVersion()
    {
        Console.WriteLine($"Versión de la aplicación: {VersionApp}");
    }
}