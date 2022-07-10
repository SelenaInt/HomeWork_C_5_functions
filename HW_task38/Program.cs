// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите число определяющее размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] arrayRealNumbers = new double[sizeArray];

  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = Math.Round(new Random().NextDouble(), 3); //new Random().NextDouble();
  }
  
  Console.WriteLine($"Ваш Рандомный Массив: [{String.Join("; ", arrayRealNumbers)}]");

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 0; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double differenceMaxAndMinNumber = maxNumber - minNumber;

  Console.WriteLine($"Разница между Максимальным ({maxNumber}) и Минимальным({minNumber}) элементами: {differenceMaxAndMinNumber}");
