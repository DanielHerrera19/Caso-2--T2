using System;
using Caso_2__T2.OPERACIONES;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_2__T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string espacio = "";
            float totalsbruto = 0;
            float totalDescuento = 0;
            float totalsneto = 0;

            Console.Write("{0:2}", "\nTrabajadores:       ");
            int nmrotrabajadores = int.Parse(Console.ReadLine());

            Calculos.Titulos();

            Calculos.TABLADESUELDOS(espacio, ref totalsbruto, ref totalDescuento, ref totalsneto, nmrotrabajadores);

            Calculos.Totales(totalsbruto, totalDescuento, totalsneto);
            Console.ReadKey();

        }
    }
}