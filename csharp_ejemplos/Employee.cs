public class Employee
{
    private string _document;

    // Propiedad de solo lectura para el identificador del empleado
    public int Id { get; }

    public string FullName { get; set; } = "";

    // Propiedad para el salario base, solo puede ser modificada dentro de la clase
    public decimal BaseSalary { get; private set; }

    public string Document
    {
        get => _document; // Devuelve el valor actual del documento
        set
        {
            // Valida que el valor no sea nulo ni contenga solo espacios en blanco
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Documento requerido");
            // Asigna el valor, eliminando espacios en blanco al inicio y final
            _document = value.Trim();
        }
    }


    public Employee(int id, string fullName, decimal baseSalary, string document)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id)); // nameof devuelve el nombre del parámetro como una cadena literal
        Id = id;
        FullName = fullName;
        SetBaseSalary(baseSalary); // Asigna el salario base usando el método de validación
        Document = document;      
    }

    public void SetBaseSalary(decimal amount)
    {
        if (amount < 1_000_000m) throw new ArgumentException("Salario mínimo no válido");
        BaseSalary = amount;
    }
}



/* Ejercicio 1
    Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
    Agrega dos constructores: uno completo y otro con precio 0 por defecto.
    Crea 2 instancias en Main y muéstralas por consola.
    Criterio pedagógico: observa si validan datos en propiedades (no en la UI), y si los mensajes de error son claros.
 */


public class Product
{
    private static int nextId = 1; // Para generar Ids únicos
    public int Id { get; } // Solo lectura
    private string name;
    private decimal price;
    private int stock;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            name = value;
        }
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (value < 0)
                throw new ArgumentException("El precio no puede ser negativo.");
            price = value;
        }
    }

    public int Stock
    {
        get => stock;
        set
        {
            if (value < 0)
                throw new ArgumentException("El stock no puede ser negativo.");
            stock = value;
        }
    }

    // Constructor completo
    public Product(string name, decimal price, int stock)
    {
        Id = nextId++;
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Constructor con precio = 0
    public Product(string name, int stock) : this(name, 0, stock) { }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Name}, Precio: {Price:C}, Stock: {Stock}";
    }
}

/* class Programa
{
    static void Main()
    {
        try
        {
            Product p1 = new Product("Laptop", 1200m, 5);
            Product p2 = new Product("Mouse", 3);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
        catch (Exception ex) { 
            Console.WriteLine($"Error: {ex.Message}"); 
        }
    }
} */
