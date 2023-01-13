/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] randomArray = new int[randomArraySize.Next(4,5),randomArraySize.Next(4,5)];
int temp = 0;
int countOfloops = 0;
FillArray(randomArray);
PrintArray(randomArray);

for(int i = 0; i < randomArray.GetLength(0); i++)
{
    while(countOfloops < randomArray.GetLength(1))
    {
        for(int j = 0; j < randomArray.GetLength(1) -1; j++)
        {
            if(randomArray[i, j] < randomArray[i, j+1])
            {
                temp = randomArray[i, j+1];
                randomArray[i, j+1] = randomArray[i, j];
                randomArray[i, j] = temp;
            }
        }
        countOfloops++;
    }
    countOfloops = 0;
}

Console.WriteLine("Sorted array: ");
for(int i = 0; i < randomArray.GetLength(0); i++)
    {
		Console.Write($"[ ");
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            Console.Write($"{randomArray[i,j]} ");
        }
		Console.Write($"]");
        Console.WriteLine();
    }