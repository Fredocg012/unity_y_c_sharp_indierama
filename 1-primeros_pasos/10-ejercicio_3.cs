string player_name;
int player_level;
string temporal;

Console.Write("Dime el nombre de tu personaje: ");
player_name = Console.ReadLine();

Console.Write("Dime el nivel de tu personaje: ");
temporal = Console.ReadLine();
player_level = Convert.ToInt32(temporal);

Console.WriteLine("Nombre: " + player_name);
Console.WriteLine("Nivel: " + player_level);



Console.ReadKey();
