// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
 int number = InputNum("Введите целое число: ");

 for (int i = 1; i <= number; i++)
 {
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < number)
        Console.Write(", ");
    else
        Console.Write(".");
 }