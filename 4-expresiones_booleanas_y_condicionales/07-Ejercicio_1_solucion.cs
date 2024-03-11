/* Escribir un programa que solicite un número
 * al usuario y determine si el valor es positivo
 * o negativo (informarlo en consola)
 * 
 * Para este ejercicio tratar el 0 como si fuera
 * un número positivo
 * */
Console.WriteLine("Ingrese un número");

int number = Convert.ToInt32(Console.ReadLine());

if(number >= 0)
{
    Console.WriteLine(number + " Es un número positivo");
}

else
{
    Console.WriteLine(number + " Es un número negativo");
}

Console.ReadKey();