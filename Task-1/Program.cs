﻿/*Итерация №1
Решение в группах задач:
1. Напишите программу, которая на вход принимает два 
числа и проверяет, является ли первое число квадратом 
второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/



Console.Clear();
Console.Write("Введите первое число = ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int numB = Convert.ToInt32(Console.ReadLine());

//int res = numB * numB;
if((numB * numB) == numA)
{
    Console.WriteLine($"значение {numA} - является квадратом числа = {numB}");
}
else
{
    Console.WriteLine($"значение {numA} - не является квадратом числа = {numB}");
}
