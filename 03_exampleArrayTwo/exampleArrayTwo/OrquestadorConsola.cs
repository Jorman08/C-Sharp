// Clase estática que orquesta la interacción por consola para inscribir personas y mostrar información relacionada.
static class OrquestadorConsola
{
    // Lista privada para almacenar las personas inscritas.
    private static List<Persona> personas = new List<Persona>();

    // Método público para solicitar los datos de las personas por consola.
    public static void solicitarDatosPersonas()
    {
        int opcion = -1; // Variable para controlar el ciclo de inscripción.
        do
        {
            // Mensaje informativo para el usuario.
            Console.WriteLine("Acá puede inscribir las personas para saber a cuales eventos pueden asistir.");
            Console.WriteLine("Si desea inscribir una persona digite un número diferente al 0. Si desea salir digite el número 0");
            
            // Lee la opción del usuario desde la consola.
            opcion = Int32.Parse(Console.ReadLine());
            
            // Si la opción es diferente de 0, se procede a inscribir una persona.
            if (opcion != 0)
            {
                // Solicita el nombre y la edad de la persona.
                Console.WriteLine("Por favor digite el nombre completo de la persona (presione enter) y la edad (presione enter)");
                string nombre = Console.ReadLine(); // Lee el nombre.
                int edad = Int32.Parse(Console.ReadLine()); // Lee la edad.

                Persona persona; // Variable para almacenar la instancia de persona.

                // Si la edad es menor a 18, se crea una instancia de Ninno.
                if (edad < 18)
                {
                    persona = new Ninno(nombre, edad);
                }
                // Si la edad es 18 o mayor, se crea una instancia de Adulto.
                else
                {
                    persona = new Adulto(nombre, edad);
                }
                // Agrega la persona a la lista de personas.
                personas.Add(persona);
            }
        } while (opcion != 0); // El ciclo continúa hasta que el usuario digite 0.

        // Al finalizar la inscripción, imprime el resumen de personas registradas.
        imprimirPersonas();
    }

    // Método público para imprimir la cantidad de personas registradas y su clasificación.
    public static void imprimirPersonas()
    {
        // Muestra la cantidad total de personas registradas.
        Console.WriteLine("La cantidad de personas registradas es:" + personas.Count);
        int numeroNinnos = 0; // Contador de niños.
        int numeroAdultos = 0; // Contador de adultos.

        // Recorre la lista de personas para contar niños y adultos.
        foreach (Persona persona in personas)
        {
            if (persona is Ninno) // Si la persona es de tipo Ninno.
            {
                numeroNinnos++;
            }
            else // Si la persona es de tipo Adulto.
            {
                numeroAdultos++;
            }
        }

        // Muestra la cantidad de niños y adultos registrados.
        Console.WriteLine("La cantidad de niños registrados es: " + numeroNinnos);
        Console.WriteLine("La cantidad de adultos registrados es: " + numeroAdultos);
    }

    // Método público para imprimir información sobre los eventos y quiénes pueden asistir.
    public static void imprimirEventos(List<Evento> eventos)
    {
        // Recorre la lista de eventos.
        foreach (Evento evento in eventos)
        {
            // Determina si pueden asistir niños al evento.
            string variante = evento.SoloAdultos ? "no" : "si";
            Console.WriteLine("En el evento: " + evento.NombreEvento + " " + variante + " pueden asistir niños");
            
            // Si el evento es solo para adultos, muestra los niños que no podrán asistir.
            if (evento.SoloAdultos)
            {
                Console.WriteLine("Es decir las siguientes personas no podrán asistir:");
                foreach (Persona persona in personas)
                {
                    if (persona is Ninno)
                    {
                        Console.WriteLine(persona.Nombre);
                    }
                }
            }
        }
    }
}