using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisNuevasFunciones
{
    public class IngresoDatos
    {
        public static int PedirIntEnRango(string m, int min, int max)
        {
            int rv = PedirInt($"{m} (Entre {min} y {max}): ");

            while (!(rv >= min && rv <= max))
            {
                Console.WriteLine("Valor fuera de rango");
                rv = PedirInt($"{m} (Entre {min} y {max}): ");
            }

            return rv;
        }

        public static double PedirDouble(string m)
        {
            double rv;
            string strRv;

            strRv = PedirString(m);

            while (!double.TryParse(strRv, out rv))
            {
                strRv = PedirString(m);
            }

            return rv;
        }


        public static int PedirInt(string m)
        {
            int rv;
            string strRv;

            strRv = PedirString(m);

            while (!int.TryParse(strRv, out rv))
            {
                strRv = PedirString(m);
            }

            return rv;
        }
        public static string PedirString(string m)
        {
            string strRv = string.Empty;
            while (true)
            {

                Console.Write(m);
                strRv = Console.ReadLine();
                if (strRv == string.Empty)
                {
                    Console.WriteLine("ERROR!!! El dato es requerido");

                }
                else
                {
                    break;
                }

            }
            return strRv;
        }

    }
}
