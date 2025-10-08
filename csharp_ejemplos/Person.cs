// Clase base Person: Representa a una persona genérica.
/* public class Person
{
    // Propiedad de solo lectura para el nombre completo.
    public string FullName { get; }

    // Constructor que inicializa el nombre completo.
    public Person(string fullName) => FullName = fullName;

    // Método virtual: permite que las clases derivadas sobreescriban su comportamiento.
    // Describe devuelve una cadena con la descripción básica de la persona.
    public virtual string Describe() => $"Persona: {FullName}";
}

// Clase EmployeeFullTime: Representa a un empleado de tiempo completo.
// Hereda de Person, lo que significa que también tiene FullName y Describe().
public class EmployeeFullTime : Person
{
    // Propiedad para el salario mensual del empleado.
    public decimal Salary { get; }

    // Constructor: recibe el nombre y el salario, y llama al constructor base para asignar el nombre.
    public EmployeeFullTime(string name, decimal salary) : base(name) => Salary = salary;

    // Sobrescribe el método Describe() de la clase base (Person).
    // Ahora incluye información adicional: el salario.
    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}";
}

// Clase Contractor: Representa a un contratista.
// Es sealed, lo que significa que NO puede ser heredada por otras clases.
public sealed class Contractor : Person
{
    // Propiedad para la tarifa por hora del contratista.
    public decimal HourRate { get; }

    // Constructor: recibe el nombre y la tarifa, y llama al constructor base para asignar el nombre.
    public Contractor(string name, decimal hourRate) : base(name) => HourRate = hourRate;
} */


/* Ejercicio 2
    Crea Manager : EmployeeFullTime con propiedad TeamSize.
    Override Describe() para incluir tamaño de equipo.
    Instancia Person, EmployeeFullTime, Manager, Contractor y llama Describe(). */




// Clase base Person: Representa a una persona genérica.
/* public class Person
{
    public string FullName { get; }
    public Person(string fullName) => FullName = fullName;

    // Método virtual para permitir sobrescritura en clases derivadas.
    public virtual string Describe() => $"Persona: {FullName}";
}

// Clase EmployeeFullTime: Empleado de tiempo completo, hereda de Person.
public class EmployeeFullTime : Person
{
    public decimal Salary { get; }
    public EmployeeFullTime(string name, decimal salary) : base(name) => Salary = salary;

    // Sobrescribe Describe para incluir salario.
    public override string Describe() => $"Empleado FT: {FullName}, salario: {Salary:C0}";
}

// Nueva clase Manager: hereda de EmployeeFullTime.
public class Manager : EmployeeFullTime
{
    // Propiedad adicional: tamaño del equipo.
    public int TeamSize { get; }

    // Constructor: recibe nombre, salario y tamaño de equipo.
    public Manager(string name, decimal salary, int teamSize) : base(name, salary)
        => TeamSize = teamSize;

    // Sobrescribe Describe para incluir tamaño del equipo.
    public override string Describe() =>
        $"Manager: {FullName}, salario: {Salary:C0}, equipo: {TeamSize} personas";
}

// Clase Contractor: Contratista, hereda de Person. Es sealed (no se puede heredar).
public sealed class Contractor : Person
{
    public decimal HourRate { get; }
    public Contractor(string name, decimal hourRate) : base(name) => HourRate = hourRate;

    // Si queremos, podemos sobrescribir Describe para incluir la tarifa.
    public override string Describe() => $"Contratista: {FullName}, tarifa: {HourRate:C0}/hora";
} */


/* class Programa
{
    static void Main()
    {
        // Instanciamos los objetos pedidos.
        var person = new Person("Carlos Pérez");
        var employee = new EmployeeFullTime("Ana Gómez", 4_200_000m);
        var manager = new Manager("Laura Torres", 8_500_000m, 10);
        var contractor = new Contractor("Luis Rojas", 120_000m);

        // Creamos una lista polimórfica (acepta Person y derivados).
        var people = new List<Person> { person, employee, manager, contractor };

        // Recorremos la lista e invocamos Describe() en cada uno.
        foreach (var p in people)
            Console.WriteLine(p.Describe());
    }
}
 */