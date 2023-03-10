// Семинар 2 задача 15 вариант 2 с выводом названия дня недели
Console.Clear();
Console.Write("Введите число от (1 до 7): ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 1 || x > 7)
{
  Console.Write("Вы ошиблись!\nВведите цифру (от 1 до 7): ");
  x = Convert.ToInt32(Console.ReadLine());
}
if (x == 1)
    Console.WriteLine("Понедельник - не выходной день");
else if (x == 2)
    Console.WriteLine("Вторник- не выходной день");
else if (x == 3)
    Console.WriteLine("Среда - не выходной день");
else if (x == 4)
    Console.WriteLine("Четверг - не выходной деньг");
else if (x == 5)
    Console.WriteLine("Пятница - не выходной день");
else if (x == 6)
    Console.WriteLine("Суббота - да это выходной день");
else
    Console.WriteLine("Воскресенье - да это выходной день");
