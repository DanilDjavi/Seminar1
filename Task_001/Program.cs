// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
int Min;
int Max;
if (numberA < numberB)
{
    Console.Write ("Min = ");
    Console.WriteLine (Min = numberA);
    Console.Write ("Max = ");
    Console.WriteLine (Max = numberB);
}
else
{
    Console.Write ("Min = ");
    Console.WriteLine(Min = numberB);
    Console.Write ("Max = ");
    Console.WriteLine (Max = numberA);
}