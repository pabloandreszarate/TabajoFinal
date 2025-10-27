namespace Final_programacion
{
    internal class Program
    {
        public string[] vehiculos = new string[5];
        public string[] clientes = new string[3];
        public string[] arreglos = new string[3];
        static int NumeroVehiculos = 0;
        static int NumeroClientes = 0;
        static int NumeroArreglos = 0;
        static int LimiteVehiculos = 20;
        static int LimiteClientes = 15;
        static int LimiteArreglos = 5;


        static void Main(string[] args)
        {
            int menu = 0;

            Console.Clear();


            Console.WriteLine("---Menu---");
            Console.WriteLine("Seleccione el nuemro de la opcion que desea usar");
            Console.WriteLine("1. Gestion de vehiculos");
            Console.WriteLine("2. Gestion de cientes");
            Console.WriteLine("3. Gestion de arreglos");
            Console.WriteLine("4. Salir");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: GestionVehiculos();
                    break;
                case 2: GestionClientes();
                    break;
                case 3: GestionArreglos();
                    break;
                case 4: Console.WriteLine("Cerrando");
                        Console.WriteLine("presione cualquier tecla para continuar");
                        Console.ReadKey();
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
                case 1: RegistrarVehiculo();
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

            static void RegistrarVehiculo()
            {
                NumeroVehiculos++;

                Console.WriteLine("ingrese la placa:");
                

                if (NumeroVehiculos >= LimiteArreglos)
                {
                    Console.WriteLine("Se ha alcanzado el limite posible de veiculos");
                }
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


            //revisar la forma de volver al menu principal y buscar que funcione bien el salir del programa
            

        }
    }
}











//pizza
