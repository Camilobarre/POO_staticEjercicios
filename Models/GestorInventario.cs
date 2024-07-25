using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class GestorInventario
{
    public static int TotalProductos = 0;
    public static void AñadirProducto()
    {
        TotalProductos++;
    }
    public static void MostrarTotalProductos()
    {
        Console.WriteLine($"Total de productos en el inventario: {TotalProductos}");
    }
}