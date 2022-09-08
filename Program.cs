// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных 
// чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2



int[] numbers = new int[10];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int MeaningPositive(int[] array)
{
    int meaning = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            meaning++;
        }
    }
    return meaning;
}
FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int meaning = MeaningPositive(numbers);
Console.WriteLine($"number of even numbers in the array: {meaning}");



// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



Console.Write($"Enter number array elements: ");
int number = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int number, int min, int max)
{
    int[] randomNumbers = new int[number];
    int SumNumbers = 0;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            SumNumbers = SumNumbers + randomNumbers[i];
        }
    }
    return SumNumbers;
}

int randomNumbers = RandomNumbers(number, 1, 10);
Console.WriteLine($"Sum of elements in odd positions: {randomNumbers}");



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат 
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int[] numb = new int[6];

int Even(int[] numb)
{
  int mid = numb.Length / 2;
  if (mid % 2 != 1){
    mid = mid + 1;
  }
  return mid;
}

int mid = Even(numb);

int[] generation = new int[mid];
FillArray(numb, 1, 10);

for(int i = 0; i < mid; i++ )
{
  generation[i] = numb[i] * numb[numb.Length-i-1];

}

if ((numb.Length / 2) % 2 != 1){
  generation[mid-1] = numb[mid-1];
}

WriteArray(numb);
WriteArray(generation);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// Например:
// [3 7 22 2 78] -> 76



double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
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

  double dec = maxNumber - minNumber;

  Console.WriteLine($"difference between the maximum ({maxNumber}) and minimal({minNumber}) elements: {dec}");



