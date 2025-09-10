public class taxi : vehiculo
{
    //propiedades (atributos)

    public int Banderazo { get; set; }
    public string NumeroPasajeros { get; set; }

    //metodos (funciones)

    public void EncenderTaximetro()
    {
        Console.WriteLine("El taximetro esta encendido");
    }
    public void ApagarTaximetro()
    {
        Console.WriteLine("El taximetro esta apagado");
    }
    // implementacion de metodo abstracto
    public override string Encender()
    {
        return "El taxi esta encendido";
    }
    public void verEncender()
    {
        Console.WriteLine(Encender());
    }
}