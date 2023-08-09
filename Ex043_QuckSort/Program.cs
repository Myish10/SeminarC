// Быстрая сортировка

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

int[] QuckSort(int[] array)
{
    if (array.Length <= 1)
        return array;
    else
    {
        int pivot = array[0];
        int count = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < pivot)
                count++;
        }
        int[] left = new int [count];
        int[] right = new int [array.Length - count -1];
        int indexLeft = 0;
        int indexRight = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < pivot)
            {
                left[indexLeft] = array[i];
                indexLeft++;
            }
            else
            {
                right[indexRight] = array[i];
                indexRight++;
            }
        }
        return QuckSort(left).Concat(new int[] {pivot}).Concat(QuckSort(right)).ToArray();

    }
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


int pos = InputNum("Введите длину массива: ");
int minValue = InputNum("Введите  минимальное число массива: ");
int maxValue = InputNum("Введите  максимальное число массива: ");
int[] myArray = CreateArray(pos);
FillArray(myArray, minValue, maxValue);
Console.WriteLine($"Исходный массив: [{string.Join(", ", myArray)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", QuckSort(myArray))}]");