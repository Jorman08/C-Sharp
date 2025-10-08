// Hacer un cajero automático siguiendo esto
// Consultar saldo, retirar dinero, salir
// El saldo inicial debe ser de 500000 pesos
// Si se elige reitrar debe solicitar el monto
// Verificar si hay saldo suficiente
// Descontar el retiro del saldo
// Mostrar el saldo actualizado
// Mostrar un mensaje de despedida al salir

/* double saldo = 500000; // Saldo inicial
bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n--- Cajero Automático ---");
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Retirar dinero");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine($"\nSu saldo actual es: {saldo:C}");
            break;
        case "2":
            Console.Write("Ingrese el monto a retirar: ");
            double montoRetiro = Convert.ToDouble(Console.ReadLine());
            if (montoRetiro > 0 && montoRetiro <= saldo)
            {
                saldo -= montoRetiro;
                Console.WriteLine($"\nRetiro exitoso. Su nuevo saldo es: {saldo}");
            }
            else
            {
                Console.WriteLine("\nNo se puede realizar el retiro.");
            }
            break;
        case "3":
            continuar = false;
            Console.WriteLine("\nGracias por usar el cajero automático. ¡Hasta luego!");
            break;
        default:
            Console.WriteLine("\nOpción no válida. Ingrese una opción válida.");
            break;
    }
    Console.WriteLine("\n-------------------------------");
} 
 */