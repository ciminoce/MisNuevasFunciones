using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MisNuevasFunciones.IngresoDatos;

namespace MisNuevasFunciones
{
    public class Mostrar
    {
        public static int MostrarMenu(string[] opciones)
        {
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine($"{opciones[i]}");
            }

            return PedirIntEnRango("Su eleccion:", 1, opciones.Length);
        }

    }
}
