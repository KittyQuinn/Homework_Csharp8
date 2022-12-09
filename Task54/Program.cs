// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Type the number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray(int [,] inputArray)
 {
     for (int i = 0; i < inputArray.GetLength(0); i++)
     {
         for (int j = 0; j < inputArray.GetLength(1); j++)
         {
             Console.Write(inputArray[i,j]);
         }
         Console.WriteLine();
     }
 }

 int [,] ChangeArray(int[,] array)
 {

     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            for (int k = 0; k<array.GetLength(1)-1; k++)
            {
                if (array[i,k]<array[i,k+1])
                {
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
         }

     }

     return array;
 }

 int[,] array2 = GetArray(rows,columns,2,9);


 PrintArray(array2);
 Console.WriteLine("__________________");

 PrintArray(ChangeArray(array2));