//Лабораторная работа 1
//Высокий уровень
Console.Write("введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("введите y :");
double y = double.Parse(Console.ReadLine());
Console.Write("введите a :");
double a = double.Parse(Console.ReadLine()); 
Console.WriteLine($"G = {(Math.Pow(Math.Cos(Math.Abs(y + x)), 2) - (x + y)) / (Math.Pow(Math.Atan(x + y), 2) * Math.Pow(x, 4))}");