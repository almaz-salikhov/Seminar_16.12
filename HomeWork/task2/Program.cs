// Программу, которая ищет точку пересечения двух прямых на плоскости
// заданных уравнениями:
// y = k1 * x + b1, 
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем

Console.WriteLine("Введите значение k1: ");
float k1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение b1: ");
float b1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите значение k2: ");
float k2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение b2: ");
float b2 = Convert.ToInt32(Console.ReadLine()); 

float x = (b2 - b1) / (k1 - k2);
float y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения заданных прямых: [{x}, {y}] ");


