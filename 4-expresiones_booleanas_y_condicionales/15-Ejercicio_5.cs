/*Para que un personaje pueda pasar a una mazmorra se tiene que cumplir alguna de las siguientes
 * condiciones
 * - Que no sea mago.
 * - Que su nivel sea mayor a 15.
 * La información se encuentra en las variables:
 * bool is_wizard;
 * int level;
 * 
 * Escribir una sentencia if indicando la condición que permite al personaje
 * pasar a la mazmorra.
 * */

bool is_wizard = false;
int level = 20;

if((is_wizard == false) || (level >= 15))
{
    Console.WriteLine("Puedes pasar a la mazmorra");
}

Console.ReadKey();