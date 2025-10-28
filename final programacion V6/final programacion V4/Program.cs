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

            do
            {

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
            }while (menu !=4);

        }

        static void GestionVehiculos()
        {
            int menu = 0;

            do
            {
                Console.WriteLine("---Gestion de vehiculos---");
                Console.WriteLine("Seleccione el numero de la opcion que desea usar");
                Console.WriteLine("1. Registrar vehiculo");
                Console.WriteLine("2. Ver lista de vehiculos");
                Console.WriteLine("3. Editar informacion de un vehiculo");
                Console.WriteLine("4. Asignar vehiculo a un cliente");
                Console.WriteLine("5. Buscar el vehiculo de un cliente ");
                Console.WriteLine("6. Volver al menu");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        RegistrarVehiculo();
                        break;
                    case 2:
                        ListaVehiculos();
                        break;
                    case 3:
                        EditarVehiculos();
                        break;
                    case 4:
                        ViehiculoAcliente();
                        break;
                    case 5:
                        BuscarVeiculoCliente();
                        break;
                    default:
                        Console.WriteLine("ingrese una opcion valida");
                        break;
                }
            }while(menu !=6);

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


                if (NumeroVehiculos >= LimiteVehiculos)
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

        static void EditarVehiculos()
        {
           Console.WriteLine("imgrese la placa del vehiculo que desea editar:");
            string placa = Console.ReadLine();
            int Marcador = BuscarPlaca(placa);

            if (Marcador == -1)
            {
                Console.WriteLine("el vehiculo no existe");
                return;
            }

            Console.WriteLine("ingrese la nueva placa:");
            vehiculos[Marcador, 0] = Console.ReadLine();
            
            Console.WriteLine("ingrese la nueva marca:");
            vehiculos[Marcador, 1] = Console.ReadLine();

            Console.WriteLine("ingrese el nuevo modelo:");
            vehiculos[Marcador, 2] = Console.ReadLine();

            Console.WriteLine("ingrese el nuevo año:");
            vehiculos[Marcador, 3] = Console.ReadLine();

            Console.WriteLine("Datos actualizados");

        }

        static void ViehiculoAcliente()
        {
            Console.WriteLine("ingrese la placa del vehiculo que desea cambiar:");
            string placa = Console.ReadLine();
            int MarcadorVehiculo = BuscarPlaca(placa);
            if(MarcadorVehiculo == -1)
            {
                Console.WriteLine("el vehiculo no existe");
                return;
            }

            Console.WriteLine("ingrese la cedula del cliente al que se le va a asignar el vehiculo:");
            string cedula = Console.ReadLine();
            int MarcadorCliente = BuscarCedula(cedula);

            if(MarcadorCliente == -1)
            {
                Console.WriteLine("el cliente no existe");
                return;
            }

            vehiculos[MarcadorVehiculo, 4] = cedula;

            Console.WriteLine("se ha asignado el veiculo correctamente");
        }

        static void BuscarVeiculoCliente()
        {
            Console.WriteLine("ingrese la cedula del cliente al cual pertenece el vehiculo que desea buscar:");
            string cedula = Console.ReadLine();
            bool existe = false;

            for (int i = 0; i < NumeroVehiculos; i++)
            {
                if (vehiculos[i, 4] == cedula)
                {
                    Console.WriteLine($"El vehiculo de este cliente es: Placa:{vehiculos[i, 0]} | Marca:{vehiculos[i, 1]} | Modelo:{vehiculos[i, 2]} | Año:{vehiculos[i, 3]} | Esta a bombre de:{vehiculos[i, 4]}");
                    existe = true;
                }
            }

            if (!existe)
            {
                Console.WriteLine("El cliente no tiene un vehiculo");
            }
        }

        static int BuscarPlaca(string placa)
        {
            for (int i = 0; i < NumeroVehiculos; i++)
                if (vehiculos[i, 0] == placa) return i;
            return -1;
        }

        static void GestionClientes()
        {
            int menu = 0;

            do
            {
                Console.WriteLine("---Gestion de clientes---");
                Console.WriteLine("Seleccione el numero de la opcion que desea usar");
                Console.WriteLine("1.Registrar un nuevo cliente");
                Console.WriteLine("2.Lista de clientes");
                Console.WriteLine("3.Editar cliente");
                Console.WriteLine("4.Volver al menu");
                menu = int.Parse(Console.ReadLine());

                switch(menu)
                {
                    case 1: AgregarCliente();
                        break;
                    case 2: ListaClientes();
                        break;
                    case 3: EedicionCliente();
                        break;
                }

            }while (menu !=4);

        }

        static void AgregarCliente()
        {
            if (NumeroClientes >= LimiteClientes)
            {
                Console.WriteLine("Se ha alcanzado el limite de clientes");
                return;
            }

            Console.WriteLine("ingrese el nombre del cliente:");
            clientes[NumeroClientes, 0] = Console.ReadLine();

            Console.WriteLine("ingrese el telefono del cliente:");
            clientes[NumeroClientes, 1] = Console.ReadLine();

            Console.WriteLine("ingrese el numero de cedula del cliente:");
            clientes[NumeroClientes, 2] = Console.ReadLine();

            NumeroClientes++;
        }

        static void ListaClientes()
        {
            if (NumeroClientes == 0)
            {
                Console.WriteLine("no hay clientes registrados");
                return;
            }

            for (int i = 0; i < NumeroClientes; i++)
            {
                Console.WriteLine($"{i + 1} | {clientes[i, 0]} | Telefono: {clientes[i, 1]} | Cedula: {clientes[i, 2]}");
            }
        }

        static void EedicionCliente()
        {
            Console.WriteLine("ingrese la cedula del cliente:");
            string cedula = Console.ReadLine();
            int marcador = BuscarCedula(cedula);

            if (marcador == -1)
            {
                Console.WriteLine("el cliente no existe");
                return;
            }

            Console.WriteLine("ingrese el nuevo nombre del cliente:");
            clientes[marcador, 0] = Console.ReadLine();

            Console.WriteLine("ingrese el nuevo numero de telefono:");
            clientes[marcador, 1] = Console.ReadLine();

            Console.WriteLine("ingrese la nueva cedula del cliente:");
            clientes[marcador, 2] = Console.ReadLine();

            Console.WriteLine("Cliente registrado de forma exitosa");
        }

        static int BuscarCedula(string cedula)
        {
            for (int i = 0; i < NumeroClientes; i++)
                if (clientes[i, 2] == cedula) return i;
            return -1;
        }

        static void GestionArreglos()
        {
            int menu = 0;
            Console.WriteLine("---Gestion de arreglos---");
            Console.WriteLine("Seleccione el numero de la opcion que desea usar");


            


        }
    }
}
