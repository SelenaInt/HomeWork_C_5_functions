// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число определяющее размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = new int[sizeArray];
int count = 0;
int sumOfArrayElements = 0;

for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(-1000,1000);
}
Console.WriteLine($"Исходный Массив: [{String.Join("; ", array)}]");

for (int index = 0; index < array.Length; index++)
{
    if (index % 2 != 0)
    {
        sumOfArrayElements+= array[index];
        count++;
    }
}
Console.WriteLine($"Количество Нечетных позиций в данном диапазоне: {count}");
Console.WriteLine($"Сумма элементов на четных позициях: {sumOfArrayElements}");