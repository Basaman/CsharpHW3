// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string userInput = Console.ReadLine () ?? "";

int number = int.Parse(userInput);

if (number % 2 == 0)
{
    Console.WriteLine ("Число является чётным");
}
else
{
Console.WriteLine ("Число не является чётным");
}



