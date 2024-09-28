using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class Menu {
        public static sbyte Run() {
            Console.WriteLine("\nMenú de opciones.\n");
            Console.WriteLine("\t 1. Gestionar socios.");
            Console.WriteLine("\t 2. Gestionar postulantes.");
            Console.WriteLine("\t 3. Gestionar Plantel.");
            Console.WriteLine("\t 0. Pulse 0 (cero) para salir.");
            Console.Write("\nIngrese el número de menú: ");
            return EntradaValidacion(Convert.ToSByte(Console.ReadLine()));
        }

        public static void Socios() {
            Console.Clear();
            Console.WriteLine("Menú socios");
        }

        public static void NoSocios() {
            Console.Clear();
            Console.WriteLine("Menú postulantes");
        }

        public static void Plantel() {
            Console.Clear();
            Console.WriteLine("Menú Plantel");
        }

        private static sbyte EntradaValidacion(sbyte opc) {
            if (opc < 0 || opc > 3) {
                Console.WriteLine("\n\t\tError el digito ingresado no corresponde con una opcion valida.");
                return -1;
            }
            return opc;
        }
    }
}
