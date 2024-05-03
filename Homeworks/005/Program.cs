/*
Задача 01
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
или "Позиция по колонкам выходит за пределы массива"
Позиции в массиве считать от единицы.
В коде, начальные условия:
int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;
Выводится: 6
*/

/*
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

int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x - 1, y - 1];
}

bool ValidatePosition(int[,] array, int x, int y)
{
    // if (x > array.GetLength(0) && y > array.GetLength(1))
    // {
    //     System.Console.WriteLine("Позиция по рядам - rows - и по колонкам - columns - выходит за пределы массива");
    //     return false;
    // }
    if (x > array.GetLength(0))
    {
        System.Console.WriteLine("Позиция по рядам - rows - выходит за пределы массива");
        return false;
    }
    if (y > array.GetLength(1))
    {
        System.Console.WriteLine("Позиция по колонкам - columns - выходит за пределы массива");
        return false;
    }

    return true;
}

void PrintResult(int[,] numbers, int x, int y)
{

System.Console.Write($"Element {x},{y} == ");
System.Console.WriteLine($"{ FindElementByPosition(numbers,x,y) } ");    

}

System.Console.Write("Input x- position of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input y - position of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("________________");
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix01 = CreateMatrix(3, 4, 11, 49);
PrintMatrix(matrix01);
System.Console.WriteLine(" ");
if (ValidatePosition(matrix01, x, y) == true)
    {
        PrintResult(matrix01,x,y);
    }

else System.Console.WriteLine("Stop program");

*/

// Задача 02
// Поменяйте местами первую и последнюю строку массива
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Начальные условия:
// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Выводится:
// 9   10  11  12
// 5   6   7   8
// 1   2   3   4




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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i,j] < 10)
//             System.Console.Write(matrix[i, j] + "       ");
//             else System.Console.Write(matrix[i, j] + "      ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Обмен первой с последней строкой
int[,] SwapFirstLastRows(int[,] array)
{
    int temp = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        temp = array[0, i];
        SwapItems(array, i);
        array[rows - 1, i] = temp;
    }

    return array;
}

// Обмен элементами массива
void SwapItems(int[,] array, int i)
{
    array[0, i] = array[array.GetLength(0) - 1,i]; 
}

void PrintResult(int[,] numbers)
{
    PrintMatrix(SwapFirstLastRows(numbers));
}

int[,] matrix01 = CreateMatrix(3, 3, 1, 20);
PrintMatrix(matrix01);
System.Console.WriteLine(" _____we change_________");
PrintResult(matrix01);





// Строка с наименьшей суммой элементов
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// выводится - 1


/* 
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



/// Вычисление сумм по строкам (на выходе массив с суммами строк)
int[] SumRows(int[,] matrix)
{
    int[] arrow = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }
        arrow[i] = sum;
        System.Console.Write($"{sum} ");
        
        sum = 0;
    }
    System.Console.WriteLine(" ");
    return arrow;
}

// Получение индекса минимального элемента в одномерном массиве
int MinIndex(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            //System.Console.WriteLine($"i={i}, min={min} ");
            //System.Threading.Thread.Sleep(3000);
            
            min = array[i];
            index = i;
        }
    }
    return index;
}

void PrintResult(int[,] numbers)
{
    System.Console.WriteLine($" Stroka nomer  = {MinIndex(SumRows(numbers))} minimalnaja suma elements");
}


int[,] matrix01 = CreateMatrix(4, 60, 1, 9);
PrintMatrix(matrix01);
System.Console.WriteLine(" _____rows with minimum sum is_________");

PrintResult(matrix01);

*/


