int level = 5;
string player_type = "Mago";
bool has_key = true;

/*Condiciones:
 * 1.- Que el jugador sea un mago.
 * 2.- Que sea al menos nivel 5.
 * */

/* // Ejemplo con if anidado
if (player_type == "Mago") 
{
    if(level >= 5)  // if anidado
    {
        Console.WriteLine("Puedes entrar a la mazmorra");
    }
}
*/

if((player_type == "Mago") && (level >= 5) && (has_key))   //(&& || !)
{
    Console.WriteLine("Puedes entrar a la mazmorra");
}

else
{
    Console.WriteLine("No puedes entar a la mazmorra");
}
Console.ReadKey();

