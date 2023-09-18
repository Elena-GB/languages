//System.Console.WriteLine("Input number: " );
//int num = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine($"Your number -> {num} ");

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//System.Console.WriteLine("Input number: " );
//int num = Convert.ToInt32(Console.ReadLine());
///System.Console.WriteLine($"Quad of {num} -> {num*num}");


// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
//    456 -> 6
//    782 -> 2
//    918 -> 8



//System.Console.WriteLine("Input three-digit number: " );
//int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num <= 999)
//{
//    System.Console.WriteLine($"Last digit of {num} -> {num%10}");
//}
//else
//{
//    System.Console.WriteLine("You input not three-digit number");
//}


// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


// System.Console.WriteLine("Input a number: " );
// int n = Convert.ToInt32(Console.ReadLine());
// int i = n*(-1);
// System.Console.Write($"n -> ");
// while (i <= n)
// {
//     System.Console.Write($"{i++} ");
// }


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// System.Console.WriteLine("Input the first number: " );
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the second number: " );
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n2*n2 == n1) 
// {
//     System.Console.WriteLine($"n1 = {n1}: n2 = {n2} -> да ");
// }
// else {
//     System.Console.WriteLine($"n1 = {n1}: n2 = {n2} -> нет ");
// }


// Домашнее задание

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Input the first number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the second number: " );
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {a} ");
// } 
// else {
//     System.Console.WriteLine($"a = {a}; b = {b} -> max = {b} ");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Input the first number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the second number: " );
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the third number: " );
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > max && b > c)
// {
//    max = b; 
// }
// if (c > max && c > b)
// {
//     max = c;
// }
// else {
//    max = a;
// }
// System.Console.WriteLine($"{a}, {b}, {c} -> {max} ");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Input an integer number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// if ((a % 2) == 0)
// {
//    System.Console.WriteLine($"{a} -> да"); 
// }
// else {
//    System.Console.WriteLine($"{a} -> нет"); 
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Input a number: " );
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number)
{
  System.Console.Write($"{i}, ");
  i = i + 2;  
}
