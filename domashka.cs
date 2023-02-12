// Задача 6: Напишите программу, которая на вход принимает
//  число и выдаёт, является ли число чётным 
//  (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1%2==0)
{
    System.Console.Write("Число ");
    System.Console.Write(number1);
    System.Console.Write(" является четным");
}
else{
    System.Console.Write("Число ");
    System.Console.Write(number1);
    System.Console.Write(" не является четным");
}