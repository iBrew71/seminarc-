﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите число от 100 до 999     ");
int A = Convert.ToInt32(Console.ReadLine());
int Mid = (A % 100 - A % 10) / 10;
if (A >= 100 && A < 1000)
   Console.WriteLine($"Второй цифрой числа {A} будет  <<<{Mid}>>> "); 
else 
    Console.Write($"Число {A} не является трезначным");