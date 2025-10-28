namespace final_programacion_V4
{
    internal class Program
    {
        static string[,] vehiculos = new string[LimiteVehiculos, 5];
        static string[,] clientes = new string[LimiteClientes, 3];
        static string[,] arreglos = new string[LimiteArreglos, 3];
        public static int NumeroVehiculos = 0;
        public static int NumeroClientes = 0;
        public static int NumeroArreglos = 0;
        const int LimiteVehiculos = 20;
        const int LimiteClientes = 15;
        const int LimiteArreglos = 5;


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
                case 1:
                    GestionVehiculos();
                    break;
                case 2:
                    GestionClientes();
                    break;
                case 3:
                    GestionArreglos();
                    break;
                case 4:
                    Console.WriteLine("Cerrando");
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("ingrese una opcion valida");
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
                    RegistrarVehiculo();
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("ingrese el numero de la placa del vehiculo que desea cambiar");
                    break;
                case 4:
                    Console.WriteLine("ingrese el numero de placa del veiculo que desea cambiar");
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
                vehiculos[NumeroVehiculos, 0] = Console.ReadLine();

                Console.WriteLine("Ingrese la marca del vehiculo");
                vehiculos[NumeroVehiculos, 1] = Console.ReadLine();

                Console.WriteLine("ingrese el modelo del veihculo");
                vehiculos[NumeroVehiculos, 2] = Console.ReadLine();

                Console.WriteLine("ingrese el año de fabricacion del vehiculo");
                vehiculos[NumeroVehiculos, 3] = Console.ReadLine();

                vehiculos[NumeroVehiculos, 4] = "";//dueño

                Console.WriteLine("se ha completado el registro de forma exitosa");


                if (NumeroVehiculos >= LimiteArreglos)
                {
                    Console.WriteLine("Se ha alcanzado el limite posible de veiculos");
                    return;
                }
            }

            static void ListaVehiculos()
            {
                if (NumeroVehiculos == 0)
                {
                    Console.WriteLine("aun no se ha registrado ningun vehiculo");
                    return;
                }

                Console.WriteLine("---Vehiculos registrados---");

                for (int i = 0; i < NumeroVehiculos; i++)
                {
                    Console.WriteLine($"{i + 1}, Placa:{vehiculos[i, 0]} | Marca:{vehiculos[i, 1]} | Modelo:{vehiculos[i, 2]} | Año:{vehiculos[i, 3]} | Esta a bombre de:{vehiculos[i, 4]}");
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


            //Buscar como volver al menu


        }
    }
}
