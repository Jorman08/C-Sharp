public class motocicleta : vehiculo
{
    //propiedades (atributos)

    public Boolean manubrio { get; set; }

    //metodos (funciones)

    public void HacerCaballito()
    {
        Console.WriteLine("La motocicleta esta haciendo un caballito");
    }
    // implementacion de metodo abstracto
    public override string Encender()
    {
        return "La motocicleta esta encendida";
    }
    public void verEncender()
    {
        Console.WriteLine(Encender());
    }
}