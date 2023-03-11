// Семинар 2 задача 13 второй вариант поинтереснее
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100)
{
  Console.Write("Третьей цифры нет.\nвведите новое число: ");
  n = Convert.ToInt32(Console.ReadLine());
}
{
  while (n > 999)
  {
    n /= 10;
  }
  Console.WriteLine(n % 10);
}
