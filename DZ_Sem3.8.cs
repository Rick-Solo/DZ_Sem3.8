// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = new int[3, 4];
// Console.WriteLine("Исходный массив" + "\n");

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + "\t");

//     }
//     Console.WriteLine();
// }
// Console.WriteLine("\n" + "Упорядоченный массив");

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             if (array[i, j] < array[i, j + 1])
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, j + 1];
//                 array[i, j + 1] = temp;
//             }
//         }
//     }
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// -----------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] array = new int[4,4];
// int[] sum = new int[array.GetLength(1)];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + "\t");
//         sum[i] += array[i,j];
//     }
//     Console.WriteLine();
//     // Console.WriteLine(sum[i]);     // <- Включить для проверки (суммы)
// }
// Console.WriteLine("\n"+"Номер строки с наименьшей суммой элементов: "+ (Array.IndexOf(sum, sum.Min())+1));

// ------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк 1 матрицы: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 1 матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("\n" + "Первая матрица:");

// int[,] matrix1 = new int[m, n];
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1); j++)
//     {
//         matrix1[i, j] = new Random().Next(10);
//         Console.Write(matrix1[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("\n" + "Вторая матрица:");

// int[,] matrix2 = new int[n, m];
// for (int i = 0; i < matrix2.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         matrix2[i, j] = new Random().Next(10);
//         Console.Write(matrix2[i,j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("\n" + "Результат произведения матриц:");
// int[,] matrixOtvet = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix2.GetLength(0); k++)
//         {
//             matrixOtvet[i,j] += matrix1[i,k] * matrix2[k, j];
//         }
//         Console.Write(matrixOtvet[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// ---------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите количество строк (x): ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (y): ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк по оси Z: ");
// int z = Convert.ToInt32(Console.ReadLine());

// if (x * y * z > 90)
// {
//     Console.WriteLine("Невозможно заполнить массив без повторения чисел! Уменьшите размерность массива.");
// }
// else
// {
//     int[] arrayRandom = new int[90];
//     for (int i = 0; i < arrayRandom.Length - 1; i++)
//     {
//         arrayRandom[i] = 10 + i;
//     }
//     for (int i = 0; i < arrayRandom.Length; i++)
//     {
//         int j = new Random().Next(arrayRandom.Length);
//         int temp = arrayRandom[j];
//         arrayRandom[j] = arrayRandom[i];
//         arrayRandom[i] = temp;
//     }

//     int[,,] matrix3D = new int[x, y, z];
//     int count = 0;
//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 matrix3D[i, j, k] = arrayRandom[count];
//                 Console.Write($"{matrix3D[i, j, k]}({i},{j},{k})" + "\t");
//                 count += 1;
//             }
//             Console.WriteLine();
//         }
//     }
// }

//--------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

int iBegin = 0, iFinal = 0;     //Во время заполнения это будут индексы начальной и конечной сторон, т.е 
int jBegin = 0, jFinal = 0;    // от какой и до какой стороны прямоугольника мы заполняем числами.

int i = 0;
int j = 0;

for (int k = 1; k <= m * n; k++)
{
    array[i,j] =k;
    if (i == iBegin && j < n - jFinal - 1) j++;
    else
    {
        if (j == n - jFinal - 1 && i < m - iFinal - 1) i++;
        else
        {
            if (i == m - iFinal - 1 && j > jBegin) j--;
            else
            {
                i--;
            }
        }
    }
    if ((i == iBegin + 1) && (j == jBegin) && (jBegin != n - jFinal - 1))
    {
        iBegin++;
        iFinal++;
        jBegin++;
        jFinal++;
    }
}

for ( i = 0; i < array.GetLength(0); i++)
{
    for ( j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}