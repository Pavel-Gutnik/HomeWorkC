// в задаче не получается вывести значение при вводе равных чисел!
Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"большее число {max}");
if(max ==a||max ==b||max==c)
Console.WriteLine("введены равные числа");
else
Console.WriteLine($"большее число {max}");
// решенос помощью преподавателя но со своим "или"









