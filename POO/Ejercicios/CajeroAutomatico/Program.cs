/* Cajero miCajero = new Cajero(1000); // Saldo inicial
int opcion;

do
{
    Console.WriteLine("\n--- MENÚ CAJERO AUTOMÁTICO ---");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Depositar dinero");
    Console.WriteLine("3. Retirar dinero");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            miCajero.ConsultarSaldo();
            break;

        case 2:
            Console.Write("Ingrese la cantidad a depositar: ");
            double deposito = double.Parse(Console.ReadLine());
            miCajero.Depositar(deposito);
            break;

        case 3:
            Console.Write("Ingrese la cantidad a retirar: ");
            double retiro = double.Parse(Console.ReadLine());
            miCajero.Retirar(retiro);
            break;

        case 4:
            Console.WriteLine("Gracias por usar el cajero.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
} while (opcion != 4);
 */