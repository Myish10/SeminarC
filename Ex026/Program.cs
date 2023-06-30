// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10 Решение с помощью строки!!!

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);
string count = "";
while (num > 0)
{
    count = num % 2 + count;
    num /= 2;
}
Console.WriteLine(count);