﻿
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Quad of {num} is {quad}");
// Задача 2. Является ли первое число квадратом второго?

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int quad = num2 * num2;
// if (quad == num1)
// {
//     Console.WriteLine("First number is quad of second number");
// }
// else
// {
//     Console.WriteLine("First number is not quad of second number");
// }

// Задача 3 Показать все целые числа в промежутке от Т до -Т.
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while(current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }
// Задача 4 принимает трехзначное число и показывает крайнее число 

Console.WriteLine("Input number three-digit number");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.WriteLine($"Last number of {num} is {result}");  

