/*
Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. Напишите программу, которая будет построчно выводить массив. Обратите внимание, что максимальный размер такого массива ограничен. Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

Например,
11 22 78
12 47 96
25 87 88
*/

Random randNumber = new Random();
int[,] arrayWithOriginalNumbers = new int[randNumber.Next(3,4),randNumber.Next(3,4)];
bool IsThisNumberAlreadyInArray(int n, int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == n)
            {
                return true;
            }
        }
    }
    return false;
}
for(int i = 0; i < arrayWithOriginalNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < arrayWithOriginalNumbers.GetLength(1); j++)
        {
            while(true)
            {
                int challenger = randNumber.Next(10,100);
                if(IsThisNumberAlreadyInArray(challenger,arrayWithOriginalNumbers) == false)
                {
                    arrayWithOriginalNumbers[i, j] = challenger;
                    break;
                }
            }
        }
    }
for(int i = 0; i < arrayWithOriginalNumbers.GetLength(0); i++)
{
    for(int j = 0; j < arrayWithOriginalNumbers.GetLength(1); j++)
    {
        Console.Write($"{arrayWithOriginalNumbers[i, j]} ");
    }
    Console.WriteLine();
}