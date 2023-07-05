// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
Console.WriteLine("Monday");
else if (a == 2)
Console.WriteLine("Tuesday");
else if (a == 3)
Console.WriteLine("Wedsday");
else if (a == 4)
Console.WriteLine("Thuesday");
else if (a == 5)
Console.WriteLine("Friday");
else if (a == 6)
Console.WriteLine("Saterday");
else if (a == 7)
Console.WriteLine("Sunday");
else
Console.WriteLine("Неверное число");