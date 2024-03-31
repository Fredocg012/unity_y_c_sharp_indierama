Console.Write("Por favor, ingrese su nombre: ");
string name = Console.ReadLine();

while(name != "Alfredo")
{
    Console.Write("Nombre incorrecto, ingrese su nombre: ");
    name = Console.ReadLine();
}
Console.WriteLine("Fuera del ciclo while");

Console.ReadKey();