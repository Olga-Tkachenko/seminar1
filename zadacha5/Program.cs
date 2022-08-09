// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю 
// цифру этого числа 
Console.WriteLine("Введите трехзначное число");
string? numberString1 = Console.ReadLine();
int number1 = int.Parse(numberString1!);
int number2 = number1-((number1/10)*10);
if (number1<=999)
if (number1>=100)
Console.WriteLine("Последняя цифра введенного числа " + number2);
else
{
    Console.WriteLine("Неверное число");
}
