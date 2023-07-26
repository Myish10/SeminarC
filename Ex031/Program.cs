// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string InputItem(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int num)
{
    return new string[num];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputItem($"Введите {i + 1}-й элемент массива: ");
    }
}

string[] CreateNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return new string[count];
}

void FillNewArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) continue;
        else newArray[j] = array[i];
        j++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
}

int number = InputNum("Введите количество элементов массива: ");
string[] myArray = CreateArray(number);
FillArray(myArray);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine();
string[] myNewArray = CreateNewArray(myArray);
FillNewArray(myArray, myNewArray);
PrintArray(myNewArray);