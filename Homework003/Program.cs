// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
string number = Console.ReadLine();
double N = Convert.ToDouble(number);
double i = N % 2;
if (i == 0)
{
    Console.WriteLine($"Число {number} чётное ");
}
else
{
    Console.WriteLine($"Число {number} нечётное ");
}