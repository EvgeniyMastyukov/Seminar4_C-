// // // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество 
// цифр в  числе. 456 -> 3 78 -> 2 89126 -> 5
// // Console.WriteLine("Введите любое число: ");
// // int num = int.Parse(Console.ReadLine());
// // int count = 1;
// // int res = num;
// // while (res / 10 >= 1)
// // {
// //     res = res / 10;
// //     count = count + 1;
// // }
// Console.WriteLine($"В числе {num} - {count} цифр");

// // Второй вариант

Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
int res = num;
while (res > 0) 
{
    res = res / 10;
    count = count + 1;
}
Console.WriteLine($"В числе {num} - {count} цифр");

// Третий вариант

// Console.WriteLine("Введите любое число: ");
// int num = int.Parse(Console.ReadLine());
// int digit = 0;
// for(int i = 1; i <= num; i = i*10)
// {
//     digit++;
// }
// Console.WriteLine($"В числе {num} - {digit} цифр");