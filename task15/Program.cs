// Семинар 2 задача 15
Console.Clear();
Console.Write("Введите число от (1 до 7): ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 1 || x > 7)
{
  Console.Write("Вы ошиблись!\nВведите цифру (от 1 до 7): ");
  x = Convert.ToInt32(Console.ReadLine());
}
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)
  Console.WriteLine("этот день не является выходным");
if (x == 6 || x == 7)
  Console.WriteLine("этот день является выходным");
