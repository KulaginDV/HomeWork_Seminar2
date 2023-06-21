/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write ("Input your number: ");
int num = Convert.ToInt32 (Console.ReadLine());

while (num > 999)
{
    num = num / 10;
}
if (num < 100)
{
    Console.Write ("Third Digit is missing");
}
else
{
    if (num > 99 && num < 999)
    {
        int result = num % 10;
        Console.Write ("Third digit - " + result);
    }
    else
    {
    while (num > 999)
    {
    num = num / 10;
    }
    num = num % 10;
    Console.Write ("Third digit - " + num);
    }
}

/*
int Mess (string message)
{
    Console.WriteLine (message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32 (value);
    return result;
}

int TrirdFig (int a)
{
    while (a > 999)
    {
        a = a / 10;
    }
    return a % 10;
}

bool NoThirdFig (int a)
{
    if (a < 100)
    {
        Console.WriteLine ("Not third digit");
        return false;
    }
    return true;
}

int a = Mess ("Input your number: ");

if (NoThirdFig (a))
{
    Console.WriteLine (NoThirdFig (a));
}
*/