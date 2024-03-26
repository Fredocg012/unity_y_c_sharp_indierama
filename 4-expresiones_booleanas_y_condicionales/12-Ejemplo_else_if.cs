int health = 100;
/*
 * Si health tiene el valor de 100 -> Salud completa
 * Sino si health está entre 70 y 99 -> Bien
 * Sino si health está entre 30 y 69 -> Precaución
 * Sino si heatlh está entre 1 y 29 -> Peligro
 * sino -> Muerto
*/

if (health == 100)
{
    Console.WriteLine("Salud completa");
}

else if ((health <= 99) && (health >= 70))
{
    Console.WriteLine("Bien");
}

else if ((health < 70) && (health >= 30))
{
    Console.WriteLine("Precaución");
}

else if ((health < 30) && (health >= 1))
{
    Console.WriteLine("Peligro");
}

else
{
    Console.WriteLine("Muerto");
}


Console.ReadKey();