/*Para que un personaje pueda pasar a una mazmorra se tiene que cumplir
 * - Que sea por lo menos nivel 10.
 * - Que posea una llave.
 * La información se encuentra en las variables:
 * bool has_key;
 * int level;
 * 
 * Escribir una sentencia if indicando la condición que permite al personaje
 * pasar a la mazmorra.
 * */

bool has_key = true;
int level = 10;

if((has_key == true) && (level >= 10))
{
    Console.WriteLine("Puedes pasar a la mazmorra");
}

else
{
    Console.WriteLine("No puedes pasar a la mazmorra");
}

Console.ReadKey();