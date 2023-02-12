// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
   number = -1 * number ;
}

int i = 2;
for (i = 2; i < number - 1 ; i = i + 2)
{
    System.Console.Write(i);
    System.Console.Write(", ");
}
if (i == number)
{
    System.Console.Write(i);
    System.Console.WriteLine(". Конец");
}

if (i == number - 1)
{
    System.Console.Write(i);
    System.Console.WriteLine(". Конец");
}