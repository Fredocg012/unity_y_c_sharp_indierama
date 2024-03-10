/* Escribir un programa que solicite un número
 * al usuario y determine si el valor es positivo
 * o negativo (informarlo en consola)
 * 
 * Para este ejercicio tratar el 0 como si fuera
 * un número positivo
 * */

string numero_cadena;

Console.Write("Dame un número: ");
numero_cadena = Console.ReadLine();

// Haciendo un casteo
int numero_entero = Convert.ToInt32(numero_cadena);

if(numero_entero >= 0)
{
    Console.WriteLine("El número ingresado es positivo");
}

else
{
    Console.WriteLine("El número ingresado es negativo");
}

Console.ReadKey();