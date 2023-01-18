// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int i = 2;

if (N <= 0)
{
Console.WriteLine("Error! Синий экран смерти!");
}
else while (i <= N)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }