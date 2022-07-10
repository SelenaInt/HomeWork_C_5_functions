// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[30];
int count = 0;

for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(100,1000);
}
Console.WriteLine($"Исходный Массив: [{String.Join("; ", array)}]");

for (int index = 0; index < array.Length; index++)
{
    if (array[index] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в данном диапазоне: {count}");