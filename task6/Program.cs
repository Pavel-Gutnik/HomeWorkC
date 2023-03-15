// задача 6
Console.Clear();
Console.Write("введите число: ");
int x = int.Parse(Console.ReadLine()!);
if (x % 2 == 0)
Console.WriteLine($"{x} чётное");
else
Console.WriteLine($"{x} нечётное");

