/*
12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.Clear();
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA % numB;

if (result == 0)
{
    Console.WriteLine($" {numA}, {numB}-> кратно");
}
else
{
    Console.WriteLine($"{numA}, {numB} -> не кратно, остаток {result}");
}