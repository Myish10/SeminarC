// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Devision(int num)
{
    int index = 0;
    while (num != 0)
    {
        num /= 2;
        index++;
    }
    return index;
}

int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] array, int num)
{
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num % 2;
            num /= 2;
        }
    }
}

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = temp;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
int number = InputNum("Введите целое число: ");
int ind = Devision(number);
int[] myArray = CreateArray(ind);

FillArray(myArray, number);
PrintArray(myArray);

ReversArray(myArray);
PrintArray(myArray);