//Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя) 

Console.WriteLine("Введите целое число: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int square = num * num;
Console.WriteLine($"Квадрат числа {num} равен {square}");

// Console.WriteLine(num * num);