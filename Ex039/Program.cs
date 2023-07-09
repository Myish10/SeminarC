// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double ExponentNum(double num1, double num2)
{
    if (num2 == 0) return 1;
    if (num2 > 0)
        return num1 * ExponentNum(num1, --num2);
    return 1 / (num1 * ExponentNum(num1, -num2 - 1));

}

int number1 = InputNum("Введите первое целое число: ");
int number2 = InputNum("Введите второе целое число: ");
double result = ExponentNum(number1, number2);
Console.WriteLine(result);