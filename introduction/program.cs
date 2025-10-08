// Console.WriteLine("Ejemplos estructuras condicionales");

// Console.WriteLine("Estructura IF");

// if simple 
// Sintaxis
// sbyte EDAD_PARAMETRO = 18;
// Console.Write("Ingrese su edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// if (edad >= EDAD_PARAMETRO) {

//     Console.WriteLine("Eres mayor de edad!");
// }

// if compuesto

// if anidado

// Hombre ideal: Cumplir todas las condiciones
// Fiel - Dinero - Detallista - personalidad - responsable - hijos - edad - estado civil - hermoso
/* Console.Write("Estado civil: ");
string estado_civil = Console.ReadLine();

Console.Write("Edad: ");
sbyte edad = sbyte.Parse(Console.ReadLine());

Console.Write("Responsable: ");
bool responsable = bool.Parse(Console.ReadLine());

Console.Write("Hijos: ");
string hijos = Console.ReadLine();

string PARAMETRO_ESTADO_CIVIL = "Soltero";
sbyte PARAMETRO_EDAD = 20;
bool PARAMETRO_RESPONSABLE = true;
string PARAMETRO_HIJOS = "Sin hijos";

if (estado_civil == PARAMETRO_ESTADO_CIVIL) {

    if (edad >= PARAMETRO_EDAD) {

        if (responsable == PARAMETRO_RESPONSABLE) {

            if (hijos != PARAMETRO_HIJOS) {

                Console.WriteLine("Eres el hombre ideal!");

            } else {
                Console.WriteLine("Hombre no ideal. Porque tiene hijos");
            }

        } else {
            Console.WriteLine("Hombre no ideal. Porque no es responsable");
        }

    } else {
        Console.WriteLine("Hombre no ideal. Eres muy joven");
    }

} else {
    Console.WriteLine("Hombre no ideal. Tienes que ser soltero");
} */


// Menú de opciones en donde la primera sea la fecha, la segunda mi nombre, la tercera un mensaje motivador y que se pueda leer por consola las opciones a elegir
/* Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Mostrar fecha");
Console.WriteLine("2. Mostrar nombre");
Console.WriteLine("3. Mostrar mensaje motivador");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"La fecha de hoy es: {DateTime.Now.ToShortDateString()}");
        break;
    case 2:
        Console.WriteLine("Mi nombre es: Wilson");
        break;
    case 3:
        Console.WriteLine("¡Sigue adelante, no te rindas!");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
} */



/* Console.WriteLine("Ingrese el valor del valgo de rodilla (en grados):");
double valgoRodilla = Convert.ToDouble(Console.ReadLine());
if (valgoRodilla < 10)
{
    Console.WriteLine("Valgo de rodilla normal.");
}
else if (valgoRodilla >= 10 && valgoRodilla < 20)
{
    Console.WriteLine("Valgo de rodilla leve.");
}
else if (valgoRodilla >= 20 && valgoRodilla < 30)
{
    Console.WriteLine("Valgo de rodilla moderado.");
}
else
{
    Console.WriteLine("Valgo de rodilla severo.");
} */

// ciclo for sirve para cuando sabemos cuantas veces se va a repetir un bloque de código
/* Console.WriteLine("Ciclo for");
for (int i = 0; i < 6; i+=2)
{
    Console.WriteLine("Edad");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    Console.WriteLine("Edad es: " + edad);
} 
 */



// ciclo while sirve para cuando no sabemos cuantas veces se va a repetir un bloque de código
// Console.WriteLine("Ciclo while");

/* int j = 0;
while (j < 6)
{
    Console.WriteLine("Ingrese su edad:");
    sbyte edad = sbyte.Parse(Console.ReadLine());
    Console.WriteLine("Edad es: " + edad);
    j += 2; // Incremento para evitar un bucle infinito
} */

/* Console.WriteLine("Edad:");
sbyte edad = sbyte.Parse(Console.ReadLine());
sbyte edad_parametro_centinela = 99;

while (edad != edad_parametro_centinela)
{
    Console.WriteLine("Puede ingresar");

    Console.WriteLine("Ingrese su edad:");
    edad = sbyte.Parse(Console.ReadLine());
}

Console.WriteLine("Pasaste el límite de la edad. ¡Hasta luego!"); */


// do while sirve para cuando no sabemos cuantas veces se va a repetir un bloque de código, pero queremos que se ejecute al menos una vez
/* Console.WriteLine("Ciclo do while");
sbyte edad_parametro_centinela = 99;
sbyte edad;

do
{
    Console.WriteLine("Ingrese su edad:");
    edad = sbyte.Parse(Console.ReadLine());

} while (edad != edad_parametro_centinela);

Console.WriteLine("Pasaste el límite de la edad. ¡Hasta luego!"); */


// Array 
/* string[] nombres = {"Ana", "Maria", "Jose", "Andres"};

foreach (var nombre in nombres) {
    Console.WriteLine(nombre);
}
 */



// Lista 
// List<string> nombres = new List<string>();

// Llenar la lista
// nombres.Capacity; // Características, en programación propiedad o atributo
// nombres.Add(); // Acciones, en programación metodos o funciones

/* nombres.Add("Ana");
nombres.Add("Maria");
nombres.Add("Jose");
nombres.Add("Andres");

foreach (string nombre in nombres) {
    Console.WriteLine(nombre);
}  */



// Lista de números 
/* List<int> anios = new List<int>();

anios.Add(2001);
anios.Add(2010);
anios.Add(2020);
anios.Add(2024);


foreach (int anio in anios)
{
    Console.Write($"{anio} - ");
} */


// Segunda manera más rápida de crear una lista
/* List<int> anios = new List<int> { 2001, 2010, 2020, 2024 };

foreach (int anio in anios) {
    Console.Write($"{anio} - ");
} */



// Diccionario (sintaxis)
/* Dictionary<tipo dato key, value> nombre_diccionario = new Dictionary<tipo dato key, value>()
{
    {"key", value},
    {"key", value},
    {"key", value}
}; */


/* Dictionary<int, string> lista_productos = new Dictionary<int, string>()
{
    {1, "Arroz"},
    {2, "Frijoles"},
    {3, "Carne"}
};

foreach (var producto in lista_productos) {
    Console.WriteLine($"{producto.Key} - {producto.Value}");
} */