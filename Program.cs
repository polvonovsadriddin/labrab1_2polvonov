//высокий уровень 10 вариант 
Console.Write("введите x0:");
double x0 = double.Parse(Console.ReadLine());
Console.Write("введите y0:");
double y0 = double.Parse(Console.ReadLine());
Console.Write("введите z0:");
double z0 = double.Parse(Console.ReadLine());
double d1 = Math.Abs(2 * x0 - 1 * y0 + 3 * z0 + 1) / (Math.Sqrt(2 * 2 + (-1 * (-1)) + 3 * 3));
double d2 = Math.Abs(4 * x0 - 2 * y0 - 0.5 * z0 - 5) / Math.Sqrt(4 * 4 + ((-2 * (-2))) + ((-0.5 * (-0.5))));
Console.WriteLine($"M1={d1:F2}");
Console.WriteLine($"M2={d2:F2}");
