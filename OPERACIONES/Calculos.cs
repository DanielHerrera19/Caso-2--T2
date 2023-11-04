using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_2__T2.OPERACIONES
{
    public class Calculos
    {

        public static int trabajadores()
        {
            Console.Write("{0:2}", "\nTrabajadores:\t\t\t");
            int nmrotrabajadores = int.Parse(Console.ReadLine());
            return nmrotrabajadores; 
        }
        public static void Titulos()
        {
            Console.Write("\n");
            Console.Write("{0:2}", "\tTrab.      HorasTrab.       Categoria         Tarifa            SBruto            Dsctos             SNeto\n");
        }
        
        public static void TABLADESUELDOS(string espacio, ref float totalsbruto, ref float totalDescuento, ref float totalsneto, int nmrotrabajadores)
        {
            int i = 1;

            while (i <= nmrotrabajadores)
            {
                float tarifa = 0f;
                Console.Write("\n{0}{1}", espacio.PadRight(4, ' '), i.ToString("").PadLeft(7, ' '));
                Console.Write("{0}{1}", espacio.PadRight(5, ' '), espacio.PadLeft(7, ' '));
                int horastrabajadas = int.Parse(Console.ReadLine());

                Console.Write("{0}{1}", espacio.PadRight(5, ' '), espacio.PadLeft(7, ' '));
                string categoriatxt = Console.ReadLine();
                switch (categoriatxt)
                {
                    case "A":
                        tarifa = 21.0f;
                        break;
                    case "B":
                        tarifa = 19.5f;
                        break;
                    case "C":
                        tarifa = 17.0f;
                        break;
                    case "D":
                        tarifa = 15.5f;
                        break;
                }
                float SBruto = horastrabajadas * tarifa;
                float Descuento;

                if (SBruto > 2500)
                {
                    Descuento = SBruto * 0.20f;
                }
                else
                {
                    Descuento = SBruto * 0.15f;
                }
                float SNeto = SBruto - Descuento;
                Salario(espacio, tarifa, SBruto, Descuento, SNeto);

                i += 1;
                totalsbruto += SBruto;
                totalDescuento += Descuento;
                totalsneto += SNeto;

            }
        }

            public static void Salario(string espacio, float tarifa, float SBruto, float Descuento, float SNeto)
        {
            Console.Write("{0}{1}", espacio.PadRight(5, ' '), tarifa.ToString("C").PadLeft(15, ' '));
            Console.Write("{0}{1}", espacio.PadRight(4, ' '), SBruto.ToString("C").PadLeft(15, ' '));
            Console.Write("{0}{1}", espacio.PadRight(2, ' '), Descuento.ToString("C").PadLeft(15, ' '));
            Console.Write("{0}{1}", espacio.PadRight(4, ' '), SNeto.ToString("C").PadLeft(15, ' '));
            Console.Write("\n");
        }

        public static void Totales(float totalsbruto, float totalDescuento, float totalsneto)
        {
            Console.Write("\n");
            Console.Write("\nTotal Sueldos Brutos:        " + totalsbruto.ToString("C"));
            Console.Write("\nTotal Descuentos:            " + totalDescuento.ToString("C"));
            Console.Write("\nTotal Sueldos Netos:         " + totalsneto.ToString("C"));
        }
    }
}