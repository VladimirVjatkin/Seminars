
    // int CountEvenItems(int[] numbers)
    // {
    //     int numeven = 0;    
    //     for (int i = 0; i < length.numbers; i++)
    //     {
    //         if (numbers[i]%2==0)
    //         {
    //             numeven++;
    //         }
    //     }
    //     return numeven;
    // }
    
    //  void PrintResult(int[] array)
    // {
        
    //     int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
    //     System.Console.Write("Number of even is = ");
    //     System.Console.WriteLine(CountEvenItems(array));
    // }

//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,90].


// int CountItemsRange(int[] numbers, int minRange, int maxRange)
//  {       int count = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i]>=10 && numbers[i]<=90)
//             {
//                 count++;
//             }
//         }
//         return count;

//  }

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива

//      System.Console.WriteLine(CountItemsRange(array, 10, 90));   


double FindMin(double[] numbers)
{
    double minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i]<minimum)
            {
                minimum=numbers[i];
            }
        }
        return minimum;
}

double FindMax(double[] numbers)
{
double maximum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i]>maximum)
            {
                maximum=numbers[i];
            }
        }
        return maximum;
}


double [] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double razdil = FindMax(array) - FindMin(array);
System.Console.WriteLine(razdil);
