/*11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

// Console.Clear();
// int num = new Random().Next(10, 1000);
// Console.WriteLine(num);
// int first = num / 100;                //Без функции!!!
// int second = num % 10;
// Console.WriteLine($"{num} ->{first}{second} ");

Console.Clear();
int num = new Random().Next(10, 1000);
Console.WriteLine(num);
//int num = Convert.ToInt32(Console.ReadLine());

int MetodDelete(int number)
{
    int first = number / 100;
    int second = number % 10;
    return first *10 + second;           //Добавили метод!!!
}
int metodDelete = MetodDelete(num);
Console.WriteLine($"{num}->{metodDelete}");