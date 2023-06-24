/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] threeDigitArray = CreateRandomArray(4, 100, 1000);
int result = AmountOfEvenNumbers(threeDigitArray);
Console.Write($"[{String.Join(", ", threeDigitArray)}] -> {result}");


// Функция по созданию массива, заполняемого случайными трёхзначными числами
int[] CreateRandomArray(int sizeArray, int minValue, int maxValue)
{
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

// Функция нахождения количества чётных чисел в массиве
int AmountOfEvenNumbers(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}