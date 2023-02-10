// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int CutNumber(int number)
{
    int result = ( number/10 ) % 10;
    return result; 
} 
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumber(num);
Console.WriteLine($"2 number of {num} is {newNum}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool DayWeek (int number) 
{
    bool Result = false;
    if (number ==6 || number ==7)
    {
        Result=true; 
    }
  return Result;
  
}
Console.Write("input number day ");
int day = Convert.ToInt32(Console.ReadLine());
bool dayW = DayWeek (day);
Console.WriteLine(dayW);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.

/*
int ThirdNumber(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = ThirdNumber(num);
Console.WriteLine(newNum);
*/