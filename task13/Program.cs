// Семинар 2 задача 13 первый вариант попроще
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
  Console.WriteLine("Третьей цифры нет");
else
 if (n > 999)
{
  n /= 10;
}
Console.WriteLine(n % 10);


