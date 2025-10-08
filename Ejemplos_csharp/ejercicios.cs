// stock de un inventario, añadir productos, eliminar productos, mostrar productos, salir
// Caso de uso: Inventario de productos
// Permitir al usuario añadir productos
//eliminar productos
// mostrar productos
// salir del programa

/* List<string> inventario = new List<string>();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Menú de Inventario ---");
    Console.WriteLine("1. Añadir producto");
    Console.WriteLine("2. Eliminar producto");
    Console.WriteLine("3. Mostrar productos");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el nombre del producto a añadir: ");
            string productoAgregar = Console.ReadLine();
            inventario.Add(productoAgregar);
            Console.WriteLine("\nProducto añadido.");
            break;
        case "2":
            Console.Write("Ingrese el nombre del producto a eliminar: ");
            string productoEliminar = Console.ReadLine();
            if (inventario.Remove(productoEliminar))
                Console.WriteLine("\nProducto eliminado.");
            else
                Console.WriteLine("\nProducto no encontrado.");
            break;
        case "3":
            Console.WriteLine("\nProductos en inventario:");
            if (inventario.Count == 0)
                Console.WriteLine("El inventario está vacío.");
            else
                foreach (var producto in inventario)
                    Console.WriteLine("- " + producto);
            break;
        case "4":
            continuar = false;
            Console.WriteLine("\nSaliendo del programa...");
            break;
        default:
            Console.WriteLine("\nOpción no válida. Ingrese una opción válida.");
            break;
    }
} */




// Encuesta de satisfacción básica: añadir y mostrar respuestas
// Caso de uso: Encuesta de satisfacción básica
// Permitir al usuario añadir respuestas y mostrarlas en consola

/* List<string> respuestas = new List<string>();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Encuesta de Satisfacción ---");
    Console.WriteLine("1. Añadir respuesta");
    Console.WriteLine("2. Mostrar respuestas");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("\nIngrese su respuesta: \n- Satisfecho\n- Neutral\n- Insatisfecho\n");
            Console.Write("Respuesta: ");
            string respuesta = Console.ReadLine();
            respuestas.Add(respuesta);
            Console.WriteLine("Respuesta añadida.");
            break;
        case "2":
            Console.WriteLine("\nRespuestas:");
            if (respuestas.Count == 0)
                Console.WriteLine("No hay respuestas.");
            else
                foreach (var mensaje in respuestas)
                    Console.WriteLine("- " + mensaje);
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción no válida. Ingrese una opción válida.");
            break;
    }
}
 */