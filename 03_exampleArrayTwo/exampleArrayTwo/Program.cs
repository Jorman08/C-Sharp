// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Crea una instancia de la clase AccesoData para acceder a los datos.
AccesoData data = new AccesoData();

// Obtiene una lista de objetos Evento llamando al método obtenerListaEventos().
List<Evento> eventos = data.obtenerListaEventos();

// Solicita al usuario que ingrese datos de personas mediante la consola.
OrquestadorConsola.solicitarDatosPersonas();

// Imprime en la consola la lista de eventos obtenida anteriormente.
OrquestadorConsola.imprimirEventos(eventos);