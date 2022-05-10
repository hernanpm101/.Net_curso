Console.Clear();

Console.WriteLine("Este programa calcula la superficie del rectangulo");
Console.WriteLine();

// decimal v = decimal.Parse("222");

Console.WriteLine("Ingrese la base del rectangulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;
if (esMayorADiez)
{
    Console.WriteLine("La superficie del rectangulo es mayor 10");
}

Console.ReadKey();








