//Лабораторная работа 3

Console.WriteLine("Введите натуральное число n>9: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine($"Число единиц: {n % 10}");
Console.WriteLine($"Число единиц: {n % 100}");