// Сортировка выбором

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

int[] SortBable(int[] array)
{
    for (int k = 0; k < array.Length - 1; k++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", SortBable(array))}]");