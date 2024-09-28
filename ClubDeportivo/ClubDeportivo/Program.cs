namespace ClubDeportivo {
    internal class Program {
        static void Main(string[] args) {

        ClubDeportivo admin = new ClubDeportivo();
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
            } while(opc != 0);

        }
    }
}
