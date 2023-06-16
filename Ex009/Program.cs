// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// d = √((хА – хВ)2 + (уА – уВ)2   Корень суммы квадратов разностей координат
// Math.Pow(value, degree)-возвращает только double
// Math.Sqrt(value)
double InputNum (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double Distance (double a1, double a2, double b1, double b2)
{
double sum = Math.Pow((a1 - b1), 2) + Math.Pow((a2 - b2), 2);
double res = Math.Sqrt(sum);
return res;
}

double num1 = InputNum("Введите координату X точки 1: ");
double num2 = InputNum("Введите координату Y точки 1: ");
double num3 = InputNum("Введите координату X точки 2: ");
double num4 = InputNum("Введите координату Y точки 2: ");

double result = Math.Round((Distance(num1, num2, num3, num4)), 2);
Console.WriteLine($"Расстояние между точками 1 и 2 = {result}");
