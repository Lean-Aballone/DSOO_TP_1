namespace ClubDeportivo {
    internal class Program {
        static void Main(string[] args) {

            ClubDeportivo admin = new ClubDeportivo();
            PrecargaDeDatos(admin);
            sbyte opc;
            do {
                opc = Menu.Run();
                switch (opc) {
                    case 1:
                        Menu.Socios(admin);
                        break;
                    case 2:
                        Menu.NoSocios();
                        break;
                    case 3:
                        Menu.Plantel();
                        break;
                    default:
                        Console.Clear();

                        break;
                }
            } while (opc != 0);
        }
        private static void PrecargaDeDatos(ClubDeportivo cd) {
            // Precarga de actividades.
            Actividades aux;
            string[] actividades = { "Fútbol", "Musculación", "Vóley", "Tenis"};
            foreach (var item in actividades)
            {
                aux = new Actividades(item);
                aux.id = Convert.ToSByte(cd.L_Actividades.Count + 1);
                cd.L_Actividades.Add(aux);
            }
        }

    }
}
