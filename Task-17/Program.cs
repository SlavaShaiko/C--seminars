/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть");
}
else
{
    Console.WriteLine("неверные координаты");
}
*/


/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return ("первая четверть"); // Решение с помощью метода
    if (xc < 0 && yc > 0) return ("вторая четверть");
    if (xc < 0 && yc < 0) return ("третья четверть");
    if (xc > 0 && yc < 0) return ("четвертая четверть");
    return ("неверные координаты");
}
string quarter = Quarter(x, y);
Console.WriteLine($"{quarter} {x} : {y}");

