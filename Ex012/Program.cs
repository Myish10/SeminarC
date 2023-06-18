// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// string Quart (int x, int y)
// {
//     if (x > 0 && y > 0) return "Точка находится в 1-ой четвети";
//     else if (x < 0 && y > 0) return "Точка находится во 2-ой четвети";
//     else if (x < 0 && y < 0) return "Точка находится в 3-й четвети";
//     else if (x > 0 && y < 0) return "Точка находится в 4-ой четвети";
//     else return "Точка находится на пересечении четвертей";
// }

// int x = InputNum("Введите координату x: ");
// int y = InputNum("Введите координату y: ");

// string res = Quart(x, y);


// Console.WriteLine(res);
int Quart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return -1;
}

int x = InputNum("Введите координату x: ");
int y = InputNum("Введите координату y: ");

int res = Quart(x, y);

if (res == -1)
    Console.WriteLine("Точка находится на пересечении четвертей");
else
    Console.WriteLine($"точка находится в {res}-й четверти");