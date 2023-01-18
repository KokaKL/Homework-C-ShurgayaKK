//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число > ");
string a = Console.ReadLine();
Console.WriteLine("Введите второе число > ");
string b = Console.ReadLine();
double A = Convert.ToDouble(a);
double B = Convert.ToDouble(b);
double max = A;
double min = A;
if (max > B)
{
    min = B;
    max = max;
}
else
{
    min = max;
    max = B;
}
Console.WriteLine($"Большим числом является {max}, а минимальным - {min}");