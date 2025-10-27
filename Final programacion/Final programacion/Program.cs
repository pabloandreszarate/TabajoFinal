namespace Final_programacion
{
    internal class Program
    {
        public int[] vehiculos = new int[0];
        public string[] clientes = new string[0];
        public string[] arreglos = new string[0];
        public bool VolverMenu = false; 
        

        static void Main(string[] args)
        {
            int menu = 0;


            Console.WriteLine("---Menu---");
            Console.WriteLine("Seleccione el nuemro de la opcion que desea usar");
            Console.WriteLine("1. Gestion de vehiculos");
            Console.WriteLine("2. Gestion de cientes");
            Console.WriteLine("3. Gestion de arreglos");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: GestionVehiculos();
                    break;
                case 2: GestionClientes();
                    break;
                case 3: GestionArreglos();
                    break;
                    default:Console.WriteLine("ingrese una opcion valida"); 
                    break;
            }


        }

        static void GestionVehiculos()
        {
            int menu = 0;
            Console.WriteLine("---Gestion de vehiculos---");
            Console.WriteLine("Seleccione el numero de la opcion que desea usar");
            Console.WriteLine("1. Registrar vehiculo");
            Console.WriteLine("2. Ver lista de vehiculos");
            Console.WriteLine("3. Editar informacion de un vehiculo");
            Console.WriteLine("4. Asignar vehiculo a un cliente");
            Console.WriteLine("5. Volver al menu");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("ingrese los datos de vehiculo");

                    break;
                case 2: Console.WriteLine("");
                    break;
                case 3: Console.WriteLine("ingrese el numero de la placa del vehiculo que desea cambiar");
                    break; 
                case 4: Console.WriteLine("ingrese el numero de placa del veiculo que desea cambiar");
                    break;
                case 5:
                    
                    
                default:
                    Console.WriteLine("ingrese una opcion valida");
                    break;
            }
        }
        static void GestionClientes()
        {
            int menu = 0;
            Console.WriteLine("---Gestion de clientes---");
            Console.WriteLine("Seleccione el numero de la opcion que desea usar");


        }

        static void GestionArreglos()
        {
            int menu = 0;
            Console.WriteLine("---Gestion de arreglos---");
            Console.WriteLine("Seleccione el numero de la opcion que desea usar");

        }
    }
}
