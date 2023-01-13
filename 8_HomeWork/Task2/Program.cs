/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1,11);
		}

    }
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
        Console.Write($"[");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
        Console.Write($"]");
	    Console.WriteLine();
	}
}

Random randomArraySize = new Random();
int[,] randomArray = new int[randomArraySize.Next(4,5),randomArraySize.Next(2,3)];
int[] arrayForCountSum = new int[randomArray.GetLength(0)];
int indexOfSmallestElement = 0;
FillArray(randomArray);
PrintArray(randomArray);

for(int i = 0; i < randomArray.GetLength(0); i++)
{
    for(int j = 0; j < randomArray.GetLength(1); j++)
    {
        arrayForCountSum[i] += randomArray[i, j];
    }    
}
for(int i = 0; i < arrayForCountSum.Length -1; i++)
{
    if(arrayForCountSum[i] > arrayForCountSum[i+1])
    {
        indexOfSmallestElement = i+1;
    }
}
Console.WriteLine();
Console.WriteLine($"String with smallest sum of elements: {indexOfSmallestElement + 1}");