/* 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите размерность массива: ");

int arraySize = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(arraySize, -100, 100);
int sumOfElements = SumOfElementsInArray();
Console.WriteLine($"[{String.Join(", ", array)}] -> {sumOfElements}");

//Функция создания массива
int[] CreateRandomArray(int arraySize, int minValue, int maxValue)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

// Функция суммирования элементов, записанных в нечётные индексы массива
int SumOfElementsInArray()
{
    int sumOfElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sumOfElements += array[i];
    }
    return sumOfElements;
}