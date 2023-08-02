/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
// Console.Write("Введите первое число: ");
// string number = Console.ReadLine();
// int num1 = int.Parse(number);
// Console.Write("Введите второе число: ");
// number = Console.ReadLine();
// int num2 = int.Parse(number);
// if (num1 == num2 * num2)
// {
//     Console.WriteLine("Да, первое число является квадратом второго!");
// }
// else
// {
//     Console.WriteLine("Нет, первое число не является квадратом второго");
// }

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2 * num2)
{
    Console.WriteLine("Да, первое число является квадратом второго!");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго");
}


// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
// Console.WriteLine("ВВедите трехзначное число");
// // int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());
// int rem = number % 10;
// Console.WriteLine(rem);