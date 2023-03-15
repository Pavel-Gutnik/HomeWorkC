Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  Console.WriteLine($"большее число {a}");
  Console.WriteLine($"меньшее число {b}");
}
else if (a < b)
{
  Console.WriteLine($"меньшее число {a}");
  Console.WriteLine($"большее число {b}");
}
else
  Console.WriteLine("введены равные числа");

//Задача2 моё решение
