// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
Console.WriteLine("Введем количество элементов массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
void FillArray(int[] arr)
{
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(0, 2);

    }
}
void PrintArray(int[] col)
{
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(col[i]);
    }
}
FillArray(array);
PrintArray(array);
