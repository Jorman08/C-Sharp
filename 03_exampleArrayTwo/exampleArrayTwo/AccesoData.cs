class AccesoData  //1
{
    // Método que retorna una lista de objetos Evento
public List<Evento> obtenerListaEventos()
{
    // Se crea una lista vacía de eventos
    List<Evento> eventos = new List<Evento>();

    // Se crean diferentes tipos de eventos
    TipoEvento cultural = new TipoEvento("Cultural");
    TipoEvento deportivo = new TipoEvento("Deportivo");
    TipoEvento exhibicion = new TipoEvento("Exhibición");
    TipoEvento feria = new TipoEvento("Feria");
    
    // Se crean instancias de eventos con su nombre, tipo y estado (activo/inactivo)
    Evento eventoUno = new Evento("Evento uno", cultural, true);
    Evento eventoDos = new Evento("Evento dos", deportivo, false);
    Evento eventoTres = new Evento("Evento tres", deportivo, true);
    Evento eventoCuatro = new Evento("Evento cuatro", feria, false);
    Evento eventoCinco = new Evento("Evento cinco", feria, true);
    Evento eventoSeis = new Evento("Evento seis", exhibicion, true);

    // Se agregan los eventos creados a la lista
    eventos.Add(eventoUno);
    eventos.Add(eventoDos);
    eventos.Add(eventoTres);
    eventos.Add(eventoCuatro);
    eventos.Add(eventoCinco);
    eventos.Add(eventoSeis);

    // Se retorna la lista de eventos
    return eventos;
}
}