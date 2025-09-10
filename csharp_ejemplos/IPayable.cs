/* // Definición de la interfaz IPayable, que obliga a implementar el método CalculatePayment.
public interface IPayable
{
    decimal CalculatePayment();
}

// Clase base abstracta para empleados, implementa IPayable(Herencia).
// Contiene el nombre completo y obliga a las clases derivadas a implementar CalculatePayment.
// Se pone clase abstracta para evitar instancias directas y que se pueda compartir
public abstract class EmployeeBase : IPayable
{
    public string FullName { get; }
    protected EmployeeBase(string name) => FullName = name;
    public abstract decimal CalculatePayment();
}

// Clase para empleados de tiempo completo.
// Hereda de EmployeeBase y define el salario mensual.
public class FullTime : EmployeeBase
{
    public decimal Monthly { get; }
    public FullTime(string name, decimal monthly) : base(name) => Monthly = monthly;
    // Retorna el pago mensual.
    public override decimal CalculatePayment() => Monthly;
}

// Clase para empleados por horas.
// Hereda de EmployeeBase y define la tarifa por hora y las horas trabajadas.
public class Hourly : EmployeeBase
{
    public decimal Rate { get; }
    public int Hours { get; }
    public Hourly(string name, decimal rate, int hours) : base(name) { Rate = rate; Hours = hours; }
    // Calcula el pago multiplicando tarifa por horas trabajadas.
    public override decimal CalculatePayment() => Rate * Hours;
}


    class Programa
    {
        static void Main()
        {
            // Lista de empleados que implementan IPayable.
            var payroll = new List<IPayable>
            {
                new FullTime("Ana", 4_200_000m),      // Empleado de tiempo completo
                new Hourly("Luis", 60_000m, 80)      // Empleado por horas
            };

            // Recorre la lista y muestra el tipo de empleado y el pago calculado.
            foreach (var p in payroll)
                Console.WriteLine($"{p.GetType().Name} -> Pago: {p.CalculatePayment():C0}");
        }
    } */



/* Ejercicio 3
    Crea IReportable con string BuildReport().
    Implementa en FullTime y Hourly.
    Recorre List<IReportable> y muestra reportes.
    Plus: agrega TaxRate y calcula retenciones (sólo en Hourly).
 */

public interface IPayable
{
    decimal CalculatePayment();
}

// Nueva interfaz para reportes
public interface IReportable
{
    string BuildReport();
}

// Clase base abstracta para empleados, implementa IPayable.
public abstract class EmployeeBase : IPayable
{
    public string FullName { get; }
    protected EmployeeBase(string name) => FullName = name;
    public abstract decimal CalculatePayment();
}

// Clase para empleados de tiempo completo.
public class FullTime : EmployeeBase, IReportable
{
    public decimal Monthly { get; }
    public FullTime(string name, decimal monthly) : base(name) => Monthly = monthly;

    public override decimal CalculatePayment() => Monthly;

    // Implementación de BuildReport()
    public string BuildReport()
    {
        return $"Empleado: {FullName} | Tipo: FullTime | Pago: {CalculatePayment():C0}";
    }
}

// Clase para empleados por horas.
public class Hourly : EmployeeBase, IReportable
{
    public decimal Rate { get; }
    public int Hours { get; }
    public decimal TaxRate { get; } // Nueva propiedad para impuestos

    public Hourly(string name, decimal rate, int hours, decimal taxRate = 0.10m) 
        : base(name) 
    { 
        Rate = rate; 
        Hours = hours; 
        TaxRate = taxRate; 
    }

    public override decimal CalculatePayment()
    {
        decimal gross = Rate * Hours;
        decimal tax = gross * TaxRate;
        return gross - tax;
    }

    // Implementación de BuildReport()
    public string BuildReport()
    {
        decimal gross = Rate * Hours;
        decimal tax = gross * TaxRate;
        decimal net = CalculatePayment();

        return $"Empleado: {FullName} | Tipo: Hourly | Pago bruto: {gross:C0} | Impuesto: {tax:C0} | Pago neto: {net:C0}";
    }
}

/* class Programa
{
    static void Main()
    {
        // Lista de empleados que implementan IPayable
        var payroll = new List<IPayable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 80)
        };

        Console.WriteLine("=== Pagos ===");
        foreach (var p in payroll)
            Console.WriteLine($"{p.GetType().Name} -> Pago: {p.CalculatePayment():C0}");

        Console.WriteLine("\n=== Reportes ===");
        // Lista de reportes
        var reports = new List<IReportable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 80)
        };

        foreach (var r in reports)
            Console.WriteLine(r.BuildReport());
    }
} */