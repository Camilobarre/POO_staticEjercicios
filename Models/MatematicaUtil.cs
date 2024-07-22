using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public class MatematicaUtil
{
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }

    public int Sumar()
    {
        return Numero1 + Numero2;
    }
    public int Restar()
    {
        return Numero1 - Numero2;
    }
    public int Multiplicar()
    {
        return Numero1 * Numero2;
    }
    public double Dividir()
    {
        return (double)Numero1 / Numero2;
    }
}