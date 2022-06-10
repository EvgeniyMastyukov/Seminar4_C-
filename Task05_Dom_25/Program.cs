// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. Задачу решить без использования Math.Pow. 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите  натуральное число B: ");
int numB = int.Parse(Console.ReadLine());
if (numB > 0)
{
    int res1 = FindLevel(numA, numB);
    Console.WriteLine($"Введеное число А в степени B = {res1}");
}
else
{
    while (numB <= 0)
    {
        Console.WriteLine("Введите корректно натуральное число B: ");
        numB = int.Parse(Console.ReadLine());
    }
    int res2 = FindLevel(numA, numB);
    Console.WriteLine($"Введеное число А в степени B = {res2}");
}

int FindLevel(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;

}


