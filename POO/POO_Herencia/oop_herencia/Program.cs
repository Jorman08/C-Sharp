Console.WriteLine("concesionario SMC");

Console.WriteLine("tipo de vehiculo? 1) taxi o 2) motocicleta");
short tipoVehiculo = short.Parse(Console.ReadLine());

Console.WriteLine("marca:");
string marca = Console.ReadLine();

Console.WriteLine("linea:");
string linea = Console.ReadLine();

Console.WriteLine("modelo:");
short modelo = short.Parse(Console.ReadLine());

Console.WriteLine("placa:");
string placa = Console.ReadLine();

// vehiculo Vehiculo_uno = new Vehiculo () { Marca = marca, Linea = linea};

taxi taxi1 = new taxi() { Modelo = modelo};

motocicleta moto = new motocicleta() { Placa = placa };


if (tipoVehiculo == 1)
{
    taxi1.verEncender();

 }
    