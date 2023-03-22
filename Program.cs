// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите кол-во строк: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] resultMatrix = GetMatrix(m, n);

// double[,] GetMatrix(int m, int n)
// {
//     double[,] matrix = new double [m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 1);  
//         }
//     }
//     return matrix;
// }

// Console.WriteLine("Матрица невещественных чисел: ");
// PrintArray(resultMatrix);

// void PrintArray(double [,] customMatrix)
// {
//     for (int i = 0; i < m; i++)
//     {
//        for (int j = 0; j < n; j++)
//        {
//         Console.Write(customMatrix[i,j] + "\t");
//        }
//        Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// Console.WriteLine("Введите координату 1");
// int fn = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine("Введите координату 2");
// int sn = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int m = 7;
// int n = 7;

// int[,] matrixResult = GetMatrix(m,n);

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0, 50);
//         }
//     }
//     return matrix;
// }

// PrintMatrix(matrixResult);

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(array[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
// SearchPosition(matrixResult);

// void SearchPosition(int[,] array)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
            
//         }
        
//     }
//     if (sn < 0 || sn > m || fn < 0 || fn > n)
//     Console.WriteLine("Элемент не найден");
//     else 
//     Console.WriteLine($"Значение элемента -> {array[fn,sn]}");
// }

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] resultMatrix = GetMatrix(3,3);

// int [,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0, 5);
//         }
//     }
//     return matrix; 
// }

// PrintArray(resultMatrix);
// Console.WriteLine();

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }



// MatrixMath(resultMatrix);

// void MatrixMath(int[,] matrixM)
// {
    
//     for (int i = 0; i < matrixM.GetLength(1); i++)
//     {
//         double count = 0;
//         for (int j = 0; j < matrixM.GetLength(0); j++)
//         {
//             count = count + matrixM[j,i];
//         }
//         Console.WriteLine("Среднее арифметической каждого столбца" + Math.Round(count / matrixM.GetLength(0),2));
        
//     }
// }