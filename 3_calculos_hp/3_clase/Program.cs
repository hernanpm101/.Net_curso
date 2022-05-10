// CLASE 3

// Borra la pantalla
Console.Clear();

// Pedimos al usario que introduzca su nombre
Console.WriteLine("Hola Ingrese su nombre: ");

// Leemos el nombre al usuario - Asignacion de variable.
string nombre;

nombre = Console.ReadLine();

// Pedimos al usario que introduzca su apellido
Console.WriteLine("Ahora por favor ingrese su apellido: ");

string apellido;
apellido = Console.ReadLine();

// Mostramos el nombre
Console.Write("hola " + nombre);
Console.WriteLine(", Este es mi segundo programa.");

Console.WriteLine("Pulse una tecla para finalizar");
Console.ReadKey();


