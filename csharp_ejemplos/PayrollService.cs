// Violación común: servicio mezcla cálculo + consola.
// Refactor: separar responsabilidades.

// Interfaz que define la responsabilidad de calcular el pago de un objeto que implementa IPayable.
public interface IPaymentCalculator
{
    // Método que recibe un objeto que implementa IPayable y devuelve un decimal con el pago calculado.
    decimal Calc(IPayable e);
}

// Implementación por defecto del cálculo de pago.
// Esta clase usa el método CalculatePayment() del objeto IPayable directamente.
public class DefaultPaymentCalculator : IPaymentCalculator
{
    // Implementa el método Calc llamando al método CalculatePayment() del empleado.
    public decimal Calc(IPayable e) => e.CalculatePayment();
}

// Interfaz que define la salida de texto (responsabilidad de mostrar información).
// Esto nos permite cambiar el medio de salida sin modificar el código del servicio.
public interface IOutput
{
    // Método que escribe una línea de texto.
    void WriteLine(string text);
}

// Implementación de IOutput que escribe en la consola.
// Separa la lógica de salida para aplicar el principio de responsabilidad única.
public class ConsoleOutput : IOutput
{
    // Implementación que usa Console.WriteLine para mostrar el texto.
    public void WriteLine(string t) => Console.WriteLine(t);
}

// Servicio principal que procesa la nómina.
// Aplica Inversión de Dependencias (DIP) al depender de abstracciones (interfaces) en lugar de clases concretas.
public class PayrollService
{
    // Dependencias inyectadas: un calculador de pagos y un mecanismo de salida.
    private readonly IPaymentCalculator _calc;
    private readonly IOutput _out;

    // Constructor que recibe las implementaciones concretas para cálculo y salida (Inyección de Dependencias).
    public PayrollService(IPaymentCalculator calc, IOutput output)
    {
        _calc = calc;   // Asigna el calculador de pago.
        _out = output;  // Asigna el mecanismo de salida.
    }

    // Método que ejecuta el proceso de nómina sobre una colección de elementos que implementan IPayable.
    public void Run(IEnumerable<IPayable> items)
    {
        // Recorre cada elemento (empleado u objeto IPayable).
        foreach (var it in items)
            // Escribe en la salida el tipo del objeto y el pago calculado, formateado como moneda (C0).
            _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
    }
}



/* Ejercicio 4
    Implementa FileOutput : IOutput que escriba a un .txt.
    Crea OvertimeCalculator : IPaymentCalculator que agregue horas extra a Hourly.
    Inyecta ambas en PayrollService y ejecuta.
 */



public class FileOutput : IOutput
{
    private readonly string _filePath;

    public FileOutput(string filePath)
    {
        _filePath = filePath;
    }

    public void WriteLine(string text)
    {
        // Agrega la línea al archivo (si no existe, lo crea).
        File.AppendAllText(_filePath, text + Environment.NewLine);
    }
}

public class OvertimeCalculator : IPaymentCalculator
{
    public decimal Calc(IPayable e)
    {
        // Si no es un empleado por horas, usamos el cálculo normal.
        if (e is Hourly hourly)
        {
            int regularHours = Math.Min(hourly.Hours, 160);
            int overtimeHours = Math.Max(hourly.Hours - 160, 0);

            // Pago normal + pago extra (1.5x)
            return (regularHours * hourly.Rate) + (overtimeHours * hourly.Rate * 1.5m);
        }

        // Para los demás tipos, usar cálculo normal.
        return e.CalculatePayment();
    }
}


/* class Programa
{
    static void Main()
    {
        var payroll = new List<IPayable>
        {
            new FullTime("Ana", 4_200_000m),
            new Hourly("Luis", 60_000m, 170) // Tiene 10 horas extra
        };

        // Ruta del archivo donde se escribirá la salida.
        string filePath = "nomina.txt";

        // Inyección de dependencias:
        IPaymentCalculator calculator = new OvertimeCalculator();
        IOutput output = new FileOutput(filePath);

        // Crear el servicio con las dependencias inyectadas.
        var service = new PayrollService(calculator, output);

        // Ejecutar la nómina (escribe en el archivo).
        service.Run(payroll);

        Console.WriteLine($"Archivo generado en: {Path.GetFullPath(filePath)}");
    }
} */
