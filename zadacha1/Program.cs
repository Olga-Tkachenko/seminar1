// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
Console.WriteLine("Программа возведения числа в квадрат");
Console.WriteLine("Пожалуйста введите целое число и нажмите ENTER:");
String? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int sqrt = number * number;
Console.WriteLine("Квадрат числа " + number + " есть число" + sqrt);
