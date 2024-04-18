//Задайте двумерный массив. Найдите элементы, у которых оба
//индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int for (int i = 0; i < rows; i++)
    {
        
    for (int j = 0; j < colums; j++)
    {
        matrix[i,j] = new Random().Next(10,100);
    }
return matrix;  
    }      


}*/
/////////////////////
///
// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);//[min, max] [0, 9]
//         }
//     }
//     return matrix;
// }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

// int[,] EvenIndxSquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
//     return matrix;
// }

// // System.Console.WriteLine("Input number of rows: ");
// // int rows = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input number of columns: ");
// // int columns = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input minimal value of arr element: ");
// // int min = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Input maximal value of arr element: ");
// // int max = Convert.ToInt32(Console.ReadLine());

// // int[,] matrix = CreateMatrix(rows, columns, min, max);
// // PrintMatrix(matrix);
// // PrintMatrix(EvenIndxSquare(matrix));

// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и
// // т.д.
// // Пример
// // 2 3 4 3
// //  4 3 4 1 => 2 + 3 + 5 = 10
// //  2 9 5 4

// int SumMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 sum += matrix[i, i];
//             }
//         }
//     }
//     return sum;
// }


// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, columns, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine(SumMatrix(matrix));

/*****************************/

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);//[min, max] [0, 9]
        }
    }
    return matrix;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}



double[] MidlSum(int[,] matrix)
{

    double[] arrow = new double[matrix.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }
        arrow[i] = (double) sum / matrix.GetLength(1);
        sum = 0;
    }
    return arrow;
}
System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix01 = CreateMatrix(rows, columns, min, max);
PrintMatrix(matrix01);

PrintArray(MidlSum(matrix01));
