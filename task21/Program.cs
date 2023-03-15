// Семинар 3 задача 21. программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координату A(1): ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B(1): ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C(1): ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату A(2): ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B(2): ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C(2): ");
double c2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2) + Math.Pow(c1 - c2, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 3)}");
