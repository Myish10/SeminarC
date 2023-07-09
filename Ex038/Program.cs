// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumDigits(int num)
{
    if ( num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

int number = InputNum("Введите целое число: ");
int result = SumDigits(number);
Console.WriteLine(result);
