/*Dada la siguiente variable
 * string user_name = "Juan"; 
 * Escribir un programa que solicite al usuario un nombre. Si
 * el usuario ingresa el mismo nombre que el que existe en la variable user_name,
 * entonces dar un saludo. Sino que muestre el mensaje "Hola desconocido"
 * */
string user_name = "Juan";
string user_input;

Console.WriteLine("Ingrese un nombre");
user_input = Console.ReadLine();
bool the_name_is_Juan = user_name == user_input;

if (the_name_is_Juan == true)
{
    Console.WriteLine("¡Hola " + user_name + "!");
}

else
{
    Console.WriteLine("¡Hola desconocido!");
}

Console.ReadKey();

