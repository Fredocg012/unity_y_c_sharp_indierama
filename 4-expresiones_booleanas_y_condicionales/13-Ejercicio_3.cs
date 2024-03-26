/*Escribir un programa que muestre los siguientes mensajes por consola
 * segúin la cantidad de slots coupados de un inventario (cariable slots_in_use):
 * - Si la cantidad de slots utilizados es de 20: "Inventario lleno".
 * - Sino si la cantidad está entre 10 y 19: "Queda poco espacio".
 * - Sino si la cantidad está entre 1 y 9: "Queda mucho espacio".
 * - Sino si la cantidad es de cero: "Inventario vacio".
 * 
 */

int slots_in_use = 20;

if(slots_in_use == 20)
{
    Console.WriteLine("Inventario lleno");
}

else if((slots_in_use < 20) && ( slots_in_use >= 10))
{
    Console.WriteLine("Queda poco espacio");
}
else if((slots_in_use < 10) && (slots_in_use >= 1))
{
    Console.WriteLine("Queda mucho espacio");
}

else
{
    Console.WriteLine("Inventario vacío");
}

Console.ReadKey(); 
