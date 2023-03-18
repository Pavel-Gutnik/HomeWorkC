// цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()),result = 1;
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < b; i++)
  result *= a;
Console.WriteLine(result);

