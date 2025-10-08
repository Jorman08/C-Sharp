using System.Security.Cryptography.X509Certificates;

public abstract class vehiculo()
{
    //propiedades (atributos)

    public string Marca { get; set; }
    public short Modelo { get; set; }
    public string Linea { get; set; }
    public string Placa { get; set; }

    //metodos (funciones)

    public abstract string Encender();
    public void Arrancar()
    {
        Console.WriteLine("El vehiculo esta arrancando");
    }
    public void Acelerar()
    {
        Console.WriteLine("El vehiculo esta acelerando");
    }
    public void Frenar()
    {
        Console.WriteLine("El vehiculo esta frenando");
    }

}