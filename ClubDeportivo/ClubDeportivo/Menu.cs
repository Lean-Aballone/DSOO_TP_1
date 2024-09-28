using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class Menu {
        private const string INGRESENUMERO = "\nIngrese el número de menú: ";
        public static sbyte Run() {
            Console.WriteLine("\nMenú de opciones.\n");
            Console.WriteLine("\t 1. Gestionar socios.");
            Console.WriteLine("\t 2. Gestionar postulantes.");
            Console.WriteLine("\t 3. Gestionar Plantel.");
            Console.WriteLine("\t 0. Pulse 0 (cero) para salir.");
            Console.Write(INGRESENUMERO);
            return EntradaValidacion(Convert.ToSByte(Console.ReadLine()), 3);
        }

        public static void Socios(ClubDeportivo clubDeportivo) {
            Console.Clear();
            Console.WriteLine("\nMenú socios:\n");
            Console.WriteLine("\t 1. Dar de alta.");
            Console.WriteLine("\t 2. Inscribir Socio en una actividad.");
            Console.WriteLine("\t 0. Volver.");
            Console.Write(INGRESENUMERO);

            switch (EntradaValidacion(Convert.ToSByte(Console.ReadLine()), 2)) {
                case 0: return;
                case 1:
                    sbyte opc;
                    Console.Write("Ingresar Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingresar Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Ingresar DNI: ");
                    uint dni = Convert.ToUInt32(Console.ReadLine());
                    do {
                        Console.WriteLine("\n\t1. Para Continuar\n\t0. Cancelar");
                        Console.Write(INGRESENUMERO);
                        opc = EntradaValidacion(Convert.ToSByte(Console.ReadLine()), 1);
                        if (opc == 0) Socios(clubDeportivo);
                        if (opc == 1) clubDeportivo.AltaSocio(nombre,apellido,dni);
                    } while (opc != 0 && opc != 1 );
                    break;
                case 2:
                    break;
                default:
                    Socios(clubDeportivo);
                    break;


            }

        }

        public static void NoSocios() {
            Console.Clear();
            Console.WriteLine("Menú postulantes");
        }

        public static void Plantel() {
            Console.Clear();
            Console.WriteLine("Menú Plantel");
        }

        private static sbyte EntradaValidacion(sbyte opc, int maxOpcion) {
            if (opc < 0 || opc > maxOpcion) {
                Console.WriteLine("\n\t\tError el digito ingresado no corresponde con una opcion valida.");
                return -1;
            }
            return opc;
        }
    }
}
