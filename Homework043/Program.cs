//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine(@"Нахождение точки пересечения 2-ух прямых, заданных уравнениями:
            y = k1 * x + b1
            y = k2 * x +b2");
Console.WriteLine();
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double xpoint = (b2 - b1) / (k1 - k2);
double ypoint = k1 * xpoint + b1;
xpoint = Math.Round(xpoint, 2);
ypoint = Math.Round(ypoint, 2);
Console.WriteLine($"Координаты точки A пересечения 2-х прямых ({xpoint}; {ypoint})");
Console.ReadKey();