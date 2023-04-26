// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b)
{
    max = a;
}
else if (a < b)
{
    max = b;
}
else
{
    max = a;
}
if (max > c)
{
    Console.WriteLine("Максимальное число " + max);
}
else if (max < c)
{
    max = c;
    Console.WriteLine("Максимальное число " + max);
}
else 
{
    Console.WriteLine("Максимальное число " + max);
}