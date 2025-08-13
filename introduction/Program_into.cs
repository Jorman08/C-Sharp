// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Progrmación estructurada
// // Ejemplo manejo de variables

// // Sintaxis de variables
// // Tipo nombreVariable = valorInicial;

// // Tipos de datos primitivos
// int edad = 30; // Entero
// Console.WriteLine($"Edad: {edad}");
// string nombre = "Juan"; // Cadena de texto
// Console.WriteLine($"Nombre: {nombre}");
// char valorInicial = 'J'; // Carácter
// Console.WriteLine($"Valor Inicial: {valorInicial}");

// // Tipos de datos numericos
// float altura = 1.75f; // Flotante
// Console.WriteLine($"Altura: {altura} metros");
// double salario = 2500.50; // Doble precisión
// Console.WriteLine($"Salario: {salario} dólares");
// decimal precio = 19.99m; // Decimal
// Console.WriteLine($"Precio: {precio} dólares");

// // Booleanos
// bool esEstudiante = true; // Booleano
// Console.WriteLine($"¿Es estudiante? {esEstudiante}");

// // Tipos de datos fecha
// DateTime fechaNacimiento = new DateTime(1993, 5, 15); // Fecha y hora
// DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now); // Solo fecha

// // Concatenar
// Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, valorInicial: {valorInicial}");

// // Operaciones con variables
// int num1 = 10;
// int num2 = 5;
// int resultadoSuma = num1 + num2; // Suma
// Console.WriteLine($"Resultado de la suma: {resultadoSuma}");

// Ejemplo sumar dos números
// Console.WriteLine("Ingrese el primer número: ");
// int numeroA = Convert.ToInt32(Console.ReadLine()); /// Convert para parsear un dato (Conversion de tipo)
// Console.Write("Ingrese el segundo número: ");
// int numeroB = int.Parse(Console.ReadLine()); // Parse para convertir un string a int
// int resultados = numeroA + numeroB; // Sumar
// Console.WriteLine($"Resultado de la suma: {resultados}");

// // Conversiones de tipos 
// string numeroComoTexto = edad.ToString(); // Convertir entero a cadena
// int edadConvertida = nombre.Parse(); // Convertir cadena a entero


// Tipos de datos complejos
// object persona = new { Nombre = "Juan", Edad = 30 }; // Objeto anónimo



// Ejercicio 1
// Solicitar al usuario Nombre, edad, estatura y peso
// Calcular el imc usando la fórmula: IMC = peso / (estatura * estatura)

/* Console.WriteLine("Ingrese su nombre: "); // Permite al usuario ingresar su nombre
string nombreUsuario = Console.ReadLine();

Console.WriteLine("Ingrese su edad: "); // Solicita al usuario su edad
int edadUsuario = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("Ingrese su estatura en metros: "); // Solicita al usuario su estatura en metros
double estatura = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su peso en kilogramos: "); // Solicita al usuario su peso en kilogramos
double pesoUsuario = double.Parse(Console.ReadLine());


Console.WriteLine("Calculando su IMC..."); // Mensaje para indicar que se está calculando el IMC

double estaturaUsuario = estatura / 100; // Convertir estatura a metros
double imc = pesoUsuario / (estaturaUsuario * estaturaUsuario); 

Console.WriteLine($"Hola {nombreUsuario}, tu IMC es: {imc:F2}"); // Mostrar el IMC con dos decimales */


// Ejercicio 2
// Conversor de monedas (de peso a otro)
// Solicitar al usuario el nombre y la cantidas de pesos colombianos
// Calcular y  mostrar el equivalente de esa cantidad en tres monedas diferentes (dólar, euro, libra esterlina)
// Mostrar el resultado en consola, mostrar la conversion en formato de moneda

/* Console.WriteLine("Ingrese su nombre: "); // Permite al usuario ingresar su nombre
string nombreUsuario = Console.ReadLine(); 

Console.WriteLine("Ingrese la cantidad de pesos colombianos: "); // Solicita al usuario la cantidad de pesos colombianos
double cantidadPesos = double.Parse(Console.ReadLine());

Console.WriteLine("Calculando las conversiones..."); // Mensaje para indicar que se están realizando las conversiones

double dolares = cantidadPesos / 3900; // Conversión de pesos a dólares
double euros = cantidadPesos / 4400; // Conversión de pesos a euros
double libras = cantidadPesos / 5000; // Conversión de pesos a libras esterlinas

// Mostrar los resultados de las conversiones en consola
Console.WriteLine($"Hola {nombreUsuario}, {cantidadPesos} pesos colombianos equivale a:");
Console.WriteLine($"- $ {dolares:F2} dólares");
Console.WriteLine($"- $ {euros:F2} euros");
Console.WriteLine($"- $ {libras:F2} libras esterlinas"); */



// Estructura de desición if simple
/* Console.WriteLine("Ingrese su edad: "); // Solicita al usuario su edad
int edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}
else
{
    Console.WriteLine("Eres menor de edad.");
}
 */

// if compuesto
/* Console.WriteLine("Ingrese su edad: "); // Solicita al usuario su edad
int edadUsuario = Convert.ToInt32(Console.ReadLine());
if (edadUsuario >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}
else if (edadUsuario >= 13 && edadUsuario < 18)
{
    Console.WriteLine("Eres un adolescente.");
}
else
{
    Console.WriteLine("Eres un niño.");
} */


// Estructura de decisión if anidado
/* Console.WriteLine("Ingrese su edad: "); // Solicita al usuario su edad
int edadUsuarioAnidada = Convert.ToInt32(Console.ReadLine());
if (edadUsuarioAnidada >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
    if (edadUsuarioAnidada >= 65)
    {
        Console.WriteLine("Eres un adulto mayor.");
    }
}
else if (edadUsuarioAnidada >= 13 && edadUsuarioAnidada < 18)
{
    Console.WriteLine("Eres un adolescente.");
}
else
{
    Console.WriteLine("Eres un niño.");
} */



// Aplicar el if en los dos ejercicios anteriores

// Ejercicio 1

/* Console.WriteLine("Ingrese su nombre: "); // Permite al usuario ingresar su nombre
string nombreUsuario = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(nombreUsuario)) // Validar que el nombre no esté vacío ni en blanco
{
    Console.WriteLine("Ingrese su edad: "); // Solicita al usuario su edad
    int edadUsuario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese su estatura en centímetros: "); // Solicita al usuario su estatura
    double estatura = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su peso en kilogramos: "); // Solicita al usuario su peso
    double pesoUsuario = double.Parse(Console.ReadLine());

    Console.WriteLine("Calculando su IMC..."); // Mensaje para indicar el cálculo

    double estaturaUsuario = estatura / 100; // Convertir estatura a metros
    double imc = pesoUsuario / (estaturaUsuario * estaturaUsuario); // Calcular IMC

    Console.WriteLine($"Hola {nombreUsuario}, tu IMC es: {imc:F2}"); // Mostrar resultado
}
else
{
    Console.WriteLine("No se ingresó un nombre válido. El programa se detendrá.");
} */



// Ejercicio 2

/* Console.WriteLine("Ingrese su nombre: ");
string nombreUsuario = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de pesos colombianos: ");
double cantidadPesos = double.Parse(Console.ReadLine());

Console.WriteLine("Confirme que la moneda es COP (escriba 'COP'): ");
string moneda = Console.ReadLine().ToUpper(); // Convierte a mayúsculas para comparar

if (moneda == "COP")
{
    if (cantidadPesos > 0)
    {
        Console.WriteLine("Calculando las conversiones...");

        double dolares = cantidadPesos / 3900;
        double euros = cantidadPesos / 4400;
        double libras = cantidadPesos / 5000;

        Console.WriteLine($"Hola {nombreUsuario}, {cantidadPesos} pesos colombianos equivale a:");
        Console.WriteLine($"- $ {dolares:F2} dólares");
        Console.WriteLine($"- $ {euros:F2} euros");
        Console.WriteLine($"- $ {libras:F2} libras esterlinas");
    }
    else
    {
        Console.WriteLine("La cantidad debe ser mayor a cero.");
    }
}
else
{
    Console.WriteLine("La moneda ingresada no es válida. Debe ser 'COP'.");
}
 */