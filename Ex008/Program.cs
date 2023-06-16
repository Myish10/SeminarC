// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string Quart (int num)
{
    if (num == 1 ) return "Точка находится в диапазоне x > 0, y > 0";
    else if (num == 2) return "Точка находится в диапазоне x < 0, y > 0";
    else if (num == 3) return "Точка находится в диапазоне x < 0, y < 0";
    else if (num == 4) return "Точка находится в диапазоне x > 0, y < 0";
    else return "Такой четверти не существует";
}

int x = InputNum("Введите номер четверти: ");

string res = Quart(x);

Console.WriteLine(res);