/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write ("Input your number: ");
int day = Convert.ToInt32 (Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write ("Your number is a NOT week day!");
}
else
{
    if (day >= 1 && day <=5)
    {
        Console.Write ("NO");
    }
    if (day ==6 || day ==7)
    {
        Console.Write ("YES");
    }
}