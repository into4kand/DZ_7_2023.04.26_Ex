// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число для проверки на чётность ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 2;
if (a == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}