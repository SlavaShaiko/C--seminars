/*5. Напишите программу, которая на вход принимает 
одно число (N), а на выходе показывает все целые 
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/
Console.Clear();
Console.Write("Введите число N= ");
int N = int.Parse(Console.ReadLine());
int index = 0;
if(N < 0)
{
  index = N;
  N = N * - 1;
}
else
{
  index = N * - 1;
}
while(index <= N)
{
    Console.Write($"{index}");
    index = index + 1;
}