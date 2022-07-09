/* 
0. Демонстрация решения.
Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/


Console.Clear();
Console.Write("Введите число = ");
int numA = Convert.ToInt32(Console.ReadLine());
int res = numA * numA;
Console.WriteLine($"Квадратное значение = {res}");