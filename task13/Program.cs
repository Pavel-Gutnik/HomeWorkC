// Семинар 2 задача 13
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100)
{
  Console.WriteLine("Третьей цифры нет.\n- введите новую цифру: ");
  n = Convert.ToInt32(Console.ReadLine());
}
{
  while (n > 999)
  {
    n /= 10;
  }
  Console.WriteLine(n % 10);
}

