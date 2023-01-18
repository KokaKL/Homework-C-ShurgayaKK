// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число > ");
string a = Console.ReadLine();
double A = Convert.ToDouble(a);
Console.WriteLine("Введите второе число > ");
string b = Console.ReadLine();
double B = Convert.ToDouble(b);
Console.WriteLine("Введите третье число > ");
string c = Console.ReadLine();
double C = Convert.ToDouble(c);

if (A > B && A > C)
{
    Console.WriteLine(A);
}
else
{
    if (B > C && B > A)
        Console.WriteLine(B);

    else
    {
        Console.WriteLine(C);
    }
}
