// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b &&  a > c)
    Console.Write($" first number = {a} Maximum ");
else if (a == b && a == c) 
    Console.Write($" {a} = {b} = {c} Ravenstvo znachenii");
else if(b > a &&  b > c)
    Console.Write($" second number = {b} Maximum ");
else 
    Console.Write($" third number = {c} Maximum ");