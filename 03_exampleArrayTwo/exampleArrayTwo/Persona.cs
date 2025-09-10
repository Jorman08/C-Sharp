abstract class Persona  //1
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad) // Constructor de la clase Persona, recibe nombre y edad como parámetros
{
    this.Nombre = nombre; // Asigna el valor del parámetro 'nombre' a la propiedad 'Nombre' del objeto actual
    this.Edad = edad;     // Asigna el valor del parámetro 'edad' a la propiedad 'Edad' del objeto actual
}
}