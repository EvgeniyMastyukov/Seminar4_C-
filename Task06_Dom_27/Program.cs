// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Задачу решить без использования строк (string). 452 -> 11 82 -> 10 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int res = num;
int sum = 0;
while (res > 0)
{
    int digit = res%10;
    res = res / 10;
    sum = sum + digit;
}
Console.WriteLine($"Сумма цифр числа {num} = {sum} ");




// int num = 11;
// int a = num%13;
// Console.WriteLine(a);
