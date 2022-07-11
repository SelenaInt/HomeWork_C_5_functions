// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число определяющее размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = new int[sizeArray];
int count = 0;
int sumOfArrayElements = 0;

for (int index = 0; index < array.Length; index = index+2)
{
    array[index] = new Random().Next(-1000,1000);

    sumOfArrayElements = sumOfArrayElements + array[index];
    count++;

    // замена условия if на одно for
    // if (index % 2 != 0)
    // {
    //     sumOfArrayElements = sumOfArrayElements + array[index];
    //     count++;
    // }
    
}
Console.WriteLine($"Исходный Массив: [{String.Join("; ", array)}]");

Console.WriteLine($"Количество Нечетных позиций в данном диапазоне: {count}");
Console.WriteLine($"Сумма элементов на четных позициях: {sumOfArrayElements}");

// nt[] array = GetIntArray(20,-999,999);
// int sum_odd_elements = 0;

// for(int i=0;i<array.Length;i=i+2)
// {
//     sum_odd_elements += array[i];
// }