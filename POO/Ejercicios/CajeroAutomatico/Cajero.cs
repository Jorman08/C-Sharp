/* public class Cajero
{
    public double Saldo { get; private set; }

    public Cajero(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo actual: ${Saldo:F2}");
    }

    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depósito exitoso. Saldo actual: ${Saldo:F2}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a 0.");
        }
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. Saldo actual: ${Saldo:F2}");
        }
        else if (cantidad > Saldo)
        {
            Console.WriteLine("Fondos insuficientes.");
        }
        else
        {
            Console.WriteLine("La cantidad a retirar debe ser mayor a 0.");
        }
    }
}
 */