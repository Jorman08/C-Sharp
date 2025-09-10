using POOWorkshop.Domain;
using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Domain.Payroll;
using POOWorkshop.Domain.People;
using POOWorkshop.Services;
using POOWorkshop.Services.Output;
using POOWorkshop.Services.Payment;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n POOWorkshop");
    Console.WriteLine("1) Clases y Objetos (Product + encapsulamiento)");
    Console.WriteLine(
        "2) Herencia (Person -> EmployeeFullTimePerson/Manager/ContractorPerson/Intern)"
    );
    Console.WriteLine("3) Polimorfismo (IPayable + EmployeeBase: FullTime/Hourly con bonus)");
    Console.WriteLine("4) Abstracción + SOLID (PayrollService con DIP)");
    Console.WriteLine("5) Demo nuevas funcionalidades");
    Console.WriteLine("0) Salir");
    Console.Write("Seleccione una opción: ");
    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            DemoClassesObjects();
            break;
        case "2":
            DemoInheritance();
            break;
        case "3":
            DemoPolymorphism();
            break;
        case "4":
            DemoSolid();
            break;
        case "5":
            DemoNewFeatures();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

static void DemoClassesObjects()
{
    Console.WriteLine("\nDemo: Clases y Objetos");
    var p1 = new Product(1, "Laptop", 3_500_000m, 5);
    var p2 = new Product(2, "Mouse", 50_000m, 20);
    // Producto con stock por defecto (10)
    var p3 = new Product(3, "Teclado", 120_000m);

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);

    Console.WriteLine("\nActualizando precios...");
    p1.SetPrice(3_700_000m);
    p2.SetPrice(45_000m);
    Console.WriteLine(p1);
    Console.WriteLine(p2);

    Console.WriteLine("\nAplicando descuentos...");
    p1.ApplyDiscount(10m); // 10% de descuento
    p2.ApplyDiscount(15m); // 15% de descuento
    Console.WriteLine($"Laptop con 10% descuento: {p1}");
    Console.WriteLine($"Mouse con 15% descuento: {p2}");

    try
    {
        p2.SetStock(-1); // Forzamos error de validación
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Validación OK: {ex.Message}");
    }

    try
    {
        var invalidProduct = new Product(4, "XY", 100m); // Nombre muy corto
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Validación de nombre OK: {ex.Message}");
    }

    try
    {
        p3.ApplyDiscount(60m); // Descuento mayor al 50%
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Validación de descuento OK: {ex.Message}");
    }
}

static void DemoInheritance()
{
    Console.WriteLine("\nDemo: Herencia");
    var people = new List<Person>
    {
        new Person("Juan Pérez"),
        new EmployeeFullTimePerson("Ana Gómez", 4_200_000m),
        new Manager("Carlos Ruiz", 8_000_000m, 12),
        new ContractorPerson("Marta Díaz", 80_000m),
        new Intern("Luis Morales", 2_500_000m, 6),
    };

    foreach (var p in people)
        Console.WriteLine(p.Describe());
}

static void DemoPolymorphism()
{
    Console.WriteLine("\nDemo: Polimorfismo (Interfaces/Abstract)");
    var hourly1 = new Hourly("Pedro", 60_000m, 100);
    var hourly2 = new Hourly("Sofía", 65_000m, 180);

    // Configurando bonus
    hourly1.SetBonus(200_000m);
    hourly2.SetBonus(350_000m);

    var payroll = new List<IPayable> { new FullTime("Laura", 4_500_000m), hourly1, hourly2 };

    Console.WriteLine("\nCálculo de pagos");
    foreach (var e in payroll)
        Console.WriteLine($"{e.GetType().Name} -> {e.CalculatePayment():C0}");

    Console.WriteLine("\nUso de List<IReportable> para BuildReport()");
    var reportables = new List<IReportable> { new FullTime("Laura", 4_500_000m), hourly1, hourly2 };

    foreach (var r in reportables)
        Console.WriteLine(r.BuildReport());
}

static void DemoSolid()
{
    Console.WriteLine("\nDemo: Abstracción + SOLID (DIP)");
    var employees = new List<IPayable>
    {
        new FullTime("Laura", 4_500_000m),
        new Hourly("Pedro", 60_000m, 100),
        new Hourly("Sofía", 65_000m, 180),
    };

    // Calculator con tiempo extra tradicional
    var calculator = new OvertimeCalculator(baseHours: 160, overtimeFactor: 1.25m);
    var outputConsole = new ConsoleOutput();
    var service = new PayrollService(calculator, outputConsole);
    service.Run(employees);

    // También escribimos a archivo para evidenciar DIP (cambiar salida sin tocar lógica)
    var filePath = Path.Combine(AppContext.BaseDirectory, "payroll.txt");
    var outputFile = new FileOutput(filePath);
    var serviceToFile = new PayrollService(calculator, outputFile);
    serviceToFile.Run(employees);

    Console.WriteLine($"Archivo generado: {filePath}");

    // Nuevo: WeekendOvertimeCalculator
    // Console.WriteLine("\n-- Usando WeekendOvertimeCalculator --");
    // var weekendCalculator = new WeekendOvertimeCalculator(overtimeFactor: 1.5m, maxHoursPerDay: 8);
    // var serviceWeekend = new PayrollService(weekendCalculator, outputConsole);
    // serviceWeekend.Run(employees);

    // // Nuevo: JsonOutput
    // var jsonPath = Path.Combine(AppContext.BaseDirectory, "payroll.json");
    // var jsonOutput = new JsonOutput(jsonPath);
    // var serviceJson = new PayrollService(calculator, jsonOutput);
    // serviceJson.Run(employees);
    // if (jsonOutput is JsonOutput jo)
    //     jo.SaveToFile();
    // Console.WriteLine($"Archivo JSON generado: {jsonPath}");
}

static void DemoNewFeatures()
{
    Console.WriteLine("\n=== DEMO: Funcionalidades Nuevas ===");

    // --- BLOQUE 1: Validación y descuento en Product ---
    Console.WriteLine("\nPrimero: Comprobamos creación de un producto y descuento aplicado.");
    try
    {
        var product = new Product(1, "Smartphone", 1_200_000m); // Usa stock predeterminado
        Console.WriteLine($"Producto inicial -> {product}");

        Console.WriteLine("Aplicando descuento del 25%...");
        product.ApplyDiscount(25m);
        Console.WriteLine($"Producto actualizado -> {product}");
    }
    catch (Exception error)
    {
        Console.WriteLine($"Ocurrió un problema: {error.Message}");
    }

    // --- BLOQUE 2: Herencia con Intern ---
    Console.WriteLine("\nSegundo: Ejemplo práctico de la clase Intern.");
    var intern = new Intern("María González", 2_000_000m, 3);
    Console.WriteLine($"Intern creado: {intern.Describe()}");

    // --- BLOQUE 3: Polimorfismo con Hourly y bonus ---
    Console.WriteLine("\nTercero: Polimorfismo con Hourly aplicando bonus.");
    var hourly = new Hourly("Roberto", 70_000m, 120);
    Console.WriteLine("Reporte inicial del empleado:");
    Console.WriteLine(hourly.BuildReport());

    hourly.SetBonus(400_000m);
    Console.WriteLine("Reporte después de agregar bonus:");
    Console.WriteLine(hourly.BuildReport());

    // --- BLOQUE 4: DIP con nuevo calculador y salida ---
    Console.WriteLine("\nPor último: Calculamos nómina usando un calculador especializado.");
    var empleados = new List<IPayable> { hourly };

    var calculadoraFines = new WeekendOvertimeCalculator(1.5m, 8);
    var salidaConsola = new ConsoleOutput();
    var servicioNomina = new PayrollService(calculadoraFines, salidaConsola);

    Console.WriteLine("\nEjecutando cálculo con WeekendOvertimeCalculator:");
    servicioNomina.Run(empleados);
}
