// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int RandomNum()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine($"Сгенерировалось число: {num}");
    return num;
}
int MaxDigit(int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else
        return second;
}
int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.WriteLine($"Максимальная цифра в числе {rand} = {maxDigit}");