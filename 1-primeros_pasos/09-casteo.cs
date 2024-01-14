// Conversiones de tipo o casteo
// De entero a float (casteo implícito o automática)
using System.Globalization;

float my_float = 5;
Console.WriteLine(my_float);

// De float a entero (casteo explícito)
int my_int = (int)2.5f;
Console.WriteLine(my_int);

// De entero a string / de float a string
int my_int_2 = 10;
float my_float_2 = 3.1416f;
string my_string = my_int_2.ToString();
string my_string_2 = my_float_2.ToString();

Console.WriteLine(my_string);
Console.WriteLine(my_string_2);

// De string a entero 
string my_string_3 = "123";
int my_int_3 = Convert.ToInt32(my_string_3);
Console.WriteLine(my_int_3);

Console.ReadKey();

