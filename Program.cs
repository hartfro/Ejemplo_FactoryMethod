using AC_Modelado_FactoryMethod;

Vehiculo vehiculo = Creador.CreadorVehiculo(Creador.MOTO);
Console.WriteLine(vehiculo.kilometrosPorHora());