/* Напишите программу, которая выводит 
случайное число зи отрезка [10,99]
и показывает наибольщую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/


Console.Clear();
int number = new Random().Next(10, 100);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
int maxDigit = MaxDigit(number);
if (maxDigit == 0) 
{
    Console.WriteLine($"{number} -> Цифры одинаковые.");
}
else 
{
    Console.WriteLine($"{number} -> {maxDigit}");
}