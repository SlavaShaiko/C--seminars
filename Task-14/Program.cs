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
int sumA = 7;
int sumB = 23;

if (numA % sumA == 0 && numA % sumB == 0)
{
    Console.WriteLine($"{numA} -> да");
}
else
{
    Console.WriteLine($"{numA} -> нет");
}




