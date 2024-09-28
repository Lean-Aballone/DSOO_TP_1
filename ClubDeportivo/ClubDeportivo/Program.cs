namespace ClubDeportivo {
    internal class Program {
        CLubDeportivo admin = new CLubDeportivo();
        static void Main(string[] args) {
            sbyte opc;
            do {
                opc = Menu.Run();
                switch (opc) {
                    case 1:
                        Menu.Socios();
                        break;
                    case 2:
                        Menu.Socios();
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
