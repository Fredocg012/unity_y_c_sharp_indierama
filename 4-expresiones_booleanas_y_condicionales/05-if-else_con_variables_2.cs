int coins = 100;
int sword_cost = 90;
bool can_buy_sword = coins >= sword_cost;
string player_name = "Canela";

if(player_name == "Canela")
{
    Console.WriteLine("Hola Canela");
}

else
{
    Console.WriteLine("Hola desconocido");
}

if(can_buy_sword)
{
    Console.WriteLine("Aquí tienes tu espada");
}
else
{
    Console.WriteLine("Te faltan monedas");
}


Console.ReadKey();

 