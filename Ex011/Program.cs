// Напишите программу, которая выводит третью цифру заданного числа (сколько разрядов в числе не известно)
Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);

int[] DigitNumber (int number)
{
    int temp = number;
    int count = 0;
    while (temp != 0)
    {
        temp /=10;
        count++;
    }
    int[] array = new int [count];
    for (int i = count - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1)
//             Console.Write(", ");
//         else
//             Console.Write(".");
//     }
// }

int[] arr = DigitNumber(num);
// PrintArray(arr);
Console.Write(arr[2]);


