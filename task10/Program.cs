// Семинар 2 задача 10 
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 1000)
{
    Console.Write("Вы ошиблись!\nВведите трёхзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine((n/10)%10);

