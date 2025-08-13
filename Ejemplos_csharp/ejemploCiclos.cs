// Calcular el imc usando la fórmula: IMC = peso / (estatura * estatura)

/* for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Ingrese su nombre:");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese su estatura en metros: ");
    double estatura = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su peso en kilogramos: ");
    double peso = double.Parse(Console.ReadLine());

    Console.WriteLine("Calculando su IMC...");

    double estaturaUsuario = estatura / 100;
    double imc = peso / (estaturaUsuario * estaturaUsuario);

    Console.WriteLine($"Hola {nombre}, tu IMC es: {imc:F2}\n");

    Console.WriteLine("-------------------------------");

    Console.WriteLine("Presione cualquier tecla para continuar o 'N' para salir.");
    string respuesta = Console.ReadLine().ToUpper();

    if (respuesta == "N")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Programa finalizado por el usuario.");
        break; 
    }
    else
    {
        Console.WriteLine("-------------------------------\n");
        Console.WriteLine("Continuando con el siguiente usuario...\n");
        
    }
} */



// Conversor de monedas (de peso a otro)
// Solicitar al usuario el nombre y la cantidas de pesos colombianos
// Calcular y  mostrar el equivalente de esa cantidad en tres monedas diferentes (dólar, euro, libra esterlina)
// Mostrar el resultado en consola, mostrar la conversion en formato de moneda

/* Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine(); 

Console.WriteLine("Ingrese la cantidad de pesos colombianos: ");
double cantidadPesos = double.Parse(Console.ReadLine());


while (true)
{
    Console.WriteLine("Confirme que la moneda es COP (escriba 'COP'): ");
    string moneda = Console.ReadLine().ToUpper(); // Convierte a mayúsculas para comparar

    if (moneda == "COP")
    {
        if (cantidadPesos > 0)
        {
            Console.WriteLine("\nCalculando las conversiones...");

            double dolares = cantidadPesos / 3900;
            double euros = cantidadPesos / 4400;
            double libras = cantidadPesos / 5000;

            Console.WriteLine($"\nHola {nombre}, {cantidadPesos} pesos colombianos equivale a:");
            Console.WriteLine($"- $ {dolares:F2} dólares");
            Console.WriteLine($"- € {euros:F2} euros");
            Console.WriteLine($"- £ {libras:F2} libras esterlinas");
        }
        else
        {
            Console.WriteLine("La cantidad debe ser mayor a cero.");
        }
        break; 
    }
    else
    {
        Console.WriteLine("La moneda ingresada no es válida. Debe ser 'COP'.");
    }
} */