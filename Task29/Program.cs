// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

int FillArray(int min, int max)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return result;
}
Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());
int fillArray = FillArray(min, max);
Console.Write ($"Массив [{min},{max}] = ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
