// // Напишите программу, которая будет принимать на вход два числа и выводить, 
// //  ли второе число кратным первому. Если число 2 не кратно числу 1, то 
// // программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно

// System.Console.WriteLine("Напишите первое число");
// double num1 = double.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Напишите второе число");
// double num2 = double.Parse(Console.ReadLine()!);


// void count(double num1, double num2)
// {
// 	if (num1 % num2 == 0)
// 	{
// 		Console.Write("Кратно");
// 	}
// 	else
// 	{
// 		System.Console.WriteLine($"Не кратно. Выводим остаток {num1 % num2} ");
// 	}
// }
// count (num1, num2);

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
string Multiplicity(int number)
{
    string res = "Нет";
    if (number % 7 == 0 && number % 23 == 0)
        res = "Да";
    return res;
}
int num = InputNum("Введите целое число: ");
string result = Multiplicity(num);
Console.WriteLine(result);
