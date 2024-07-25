using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_staticEjercicios.Models;
public static class UtilidadFecha
{
    public static int DiasEntreFechas(DateTime fecha1, DateTime fecha2)
    {
        TimeSpan diferencia = fecha2 - fecha1;
        return Math.Abs(diferencia.Days);
    }
}