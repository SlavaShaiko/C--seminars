/*3. Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.Clear();
Console.Write("Введите день недели = ");
int day = Convert.ToInt32(Console.ReadLine());
string Понедельник = Convert.ToString(1);
string Вторник = Convert.ToString(2);
string Среда = Convert.ToString(3);
string Четверг = Convert.ToString(4);
string Пятница = Convert.ToString(5);
string Суббота = Convert.ToString(6);
string Воскресенье = Convert.ToString(7);

if(day == 1)
   Console.WriteLine($"День недели - Понедельник");
   if(day == 2)
       Console.WriteLine($"День недели - Вторник");
       if(day == 3)
          Console.WriteLine($"День недели - Среда");
          if(day == 4)
             Console.WriteLine($"День недели - Четверг");
             if(day == 5)
                Console.WriteLine($"День недели - Пятница");
                if(day == 6)
                   Console.WriteLine($"День недели - Суббота");
                   if(day == 7)
                      Console.WriteLine($"День недели - Воскресенье");