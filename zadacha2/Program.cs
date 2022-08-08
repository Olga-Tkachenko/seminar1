// напишите программу, которая на вход принимает два числа и проверяет, является ли 
// перввое число квадратом второго
Console.WriteLine("Ведите первое число");
string numberString = Console.ReadLine();
int numberA = int.Parse(numberString);
Console.WriteLine("Введите второе число");
string numberStringA = Console.ReadLine();
int numberB = int.Parse(numberStringA);
int sqrt = numberB * numberB;
if (numberA == sqrt)
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}
