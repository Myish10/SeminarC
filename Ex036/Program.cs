// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

void PrintNumbers(int start, int end)
{
    if (start > end) return;
    Console.Write(start + " ");
    PrintNumbers(++start, end);
}

int number = InputNum("Введите целое число: ");
PrintNumbers(1, number);
