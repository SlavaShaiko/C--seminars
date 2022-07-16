/*Задача 18. Напишити программу, 
которая по задонному номеручетверти, 
показывает диапазон возможных координат точек в этой четверти от x до y
Console.Clear();
*/
Console.WriteLine("Введите номер четверти ");
int x = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc)
{
    if (xc == 1) return ("xc > 0 и yc > 0");
    if (xc == 2) return ("xc < 0 и yc > 0");
    if (xc == 3) return ("xc < 0 и yc < 0");
    if (xc == 4) return ("xc > 0 и yc < 0");
    return ("неверные координаты");
}
string quarter = Quarter(x);
Console.WriteLine($"{quarter}");
