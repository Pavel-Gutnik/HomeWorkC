﻿//  Задача 23 программa, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
  Console.WriteLine($"{i} ^ 2 = {i * i * i}");
