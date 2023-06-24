/* 
Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62
*/

Console.Write("Задайте размерность массива: ");
int arraySize = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(arraySize, -100, 100);
int maxElement = MaxElementInArray(array);
int minElement = MinElementInArray(array);
int sumElements = maxElement - minElement;
Console.WriteLine($"[{String.Join(", ", array)}] => {maxElement} - {minElement} = {sumElements}");

//Функция нахождения максимального значения элемента массива
int MaxElementInArray(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

//Функция нахождения минимального значения элемента массива
int MinElementInArray(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

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