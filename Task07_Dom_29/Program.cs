//Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
//Размер массива определяется пользователем. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());

int[] array = new int[number];
int lenght = array.Length;
for (int count = 0; count < lenght; count++)
{
    Console.Write($"Введите {count} элемент массива + клавиша Enter    ");
    array[count] = int.Parse(Console.ReadLine());
}
Console.Write($" Массив array    ");
for (int i = 0; i < lenght; i++)
{
    Console.Write($" {array[i]}  ");
}