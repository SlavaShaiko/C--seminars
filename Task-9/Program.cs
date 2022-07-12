/* Напишите программу, которая выводит 
случайное число зи отрезка [10,99]
и показывает наибольщую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

Console.Clear();
/*int num = new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) Console.WriteLine("Цифры одинаковые.");
if (firstDigit > secondDigit) Console.WriteLine($"{num} -> {firstDigit}");
else Console.WriteLine($"{num} -> {secondDigit}"); 
*/

//int num = new Random().Next(10, 100);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit == secondDigit) return 0;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
int maxDigit = MaxDigit(num);
if (maxDigit == 0) Console.WriteLine($"{num} -> Цифры одинаковые.");
else Console.WriteLine($"{num} -> {maxDigit}");
