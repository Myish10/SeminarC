// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[] PosMin(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) 
            {
                min = array[i, j];
                result[0] = i;
                result[1] = j;
            }        
        }
    return result;
}

void PrintSortArray(int[] sortArray)
{
    for (int i = 0; i < sortArray.Length; i++)
    {
        Console.Write(sortArray[i] + " ");
    }
    Console.WriteLine();

}


int[,] SortArray(int[,] array, int[] minPosArray)
{
    int[,] sortArray  = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minPosArray[0]) continue;
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == minPosArray[1]) continue;
                else sortArray[k, l] = array[i, j];
                l++;
            }
            l = 0;
            k++;
        }
    }
    return sortArray;
}


int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] my2DArray = Create2DArray(rows, columns);
Fill2DArray(my2DArray, minValue, maxValue);
Print2DArray(my2DArray);
Console.WriteLine();

int[] myPosMinArray = PosMin(my2DArray);
PrintSortArray(myPosMinArray);
Console.WriteLine();

int[,] mySortArray = SortArray(my2DArray, myPosMinArray);
Print2DArray(mySortArray);

