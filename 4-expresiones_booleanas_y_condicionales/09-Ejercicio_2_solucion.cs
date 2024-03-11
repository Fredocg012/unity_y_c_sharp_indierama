/*Dada la siguiente variable
 * string user_name = "Juan"; 
 * Escribir un programa que solicite al usuario un nombre. Si
 * el usuario ingresa el mismo nombre que el que existe en la variable user_name,
 * entonces dar un saludo. Sino que muestre el mensaje "Hola desconocido"
 * */
String user_name = "Juan";

Console.WriteLine("Ingrese su nombre: ");
string name = Console.ReadLine();

if(name == user_name)
{
    Console.WriteLine("Hola " + user_name);
}

else
{
    Console.WriteLine("¡Hola desconocido!");
}
