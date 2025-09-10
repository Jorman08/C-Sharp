// Definición de la clase Ninno que hereda de la clase Persona
class Ninno : Persona  //3
{
    // Constructor de la clase Ninno que recibe nombre y edad
    public Ninno(string nombre, int edad) : base(nombre, edad)
    {
        // El constructor llama al constructor de la clase base (Persona)
        // y le pasa los parámetros nombre y edad.
        // No se agrega lógica adicional aquí.
    }
}