// Clase que representa un evento
class Evento  //2
{
    // Variable estática que cuenta el número total de eventos creados
    public static int numeroDeEventos = 0;

    // Propiedad para el nombre del evento
    public string NombreEvento { get; set; }

    // Propiedad para el tipo de evento (debe existir un enum o clase TipoEvento)
    public TipoEvento Tipo { get; set; }

    // Propiedad que indica si el evento es solo para adultos
    public bool SoloAdultos { get; set; }

    // Constructor que inicializa las propiedades y aumenta el contador de eventos
    public Evento(string nombreEvento, TipoEvento tipo, bool soloAdultos)
    {
        // Asigna el nombre del evento
        this.NombreEvento = nombreEvento;

        // Asigna el tipo de evento
        this.Tipo = tipo;

        // Indica si el evento es solo para adultos
        this.SoloAdultos = soloAdultos;

        // Incrementa el contador de eventos cada vez que se crea uno nuevo
        numeroDeEventos++;
    }
}