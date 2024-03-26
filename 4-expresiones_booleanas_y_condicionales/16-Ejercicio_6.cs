/*Escribir un programa que solicite un número al usuario y que indique
 * si tal número es par o impar
 * */

String numero_string;

Console.Write("Escribe un número: ");

numero_string = Console.ReadLine();
int numero_int = Convert.ToInt32(numero_string);

if(numero_int % 2 == 0)
{
    Console.WriteLine("Tu número es par");
}

else
{
    Console.WriteLine("Tu número es impar");
}

Console.ReadKey();