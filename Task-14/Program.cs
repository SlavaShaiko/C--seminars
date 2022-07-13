/*14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.Clear();
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if (numA % a == 0 && numA % b == 0)
{
    Console.WriteLine($"{numA} -> да");
}
else
{
    Console.WriteLine($"{numA} -> нет");
}




