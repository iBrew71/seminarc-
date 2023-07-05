//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Enter number xxx: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Last number: {n % 10}");