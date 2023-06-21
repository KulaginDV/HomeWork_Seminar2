/*
Задача 10:
Написать программу, которая принимает на вход 
трехзначное число и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine ("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

void SecFig (int a)
{
    int num2 = a / 10 % 10;
    Console.Write ("Second figure in your number - " + num2);
}

if (num < 100 || num >= 1000)
{
    Console.Write ("You input incorrect number!");
}
else
{
    SecFig (num);
}