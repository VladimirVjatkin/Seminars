 
/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool isPrime(int num)
{
    if(num==1) return false;
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(isPrime(array[i])) count++;
    }
    return count;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array)
System.Console.WriteLine(CountPrime(array));
*/

/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool IsPrime(int num)
{
    if(num == 1) return false; 
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i])) count++;
    }
    return count;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(CountPrime(array));
*/

// 002
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2
/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool NumCounter(int num)
{
    if(num == 1) return false; 
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i])) count++;
    }
    return count;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine(CountPrime(array));

*/

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
    }
    return array;
}

int[] InputArray()
{
    System.Console.WriteLine("Input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write("Input " + (i + 1) +" element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

bool IsPrime(int num)
{
    if(num == 1) return false; 
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i])) count++;
    }
    return count;
}

int NumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 10 == 1 && array[i] % 7 == 0) count++;
    }
    return count;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[] array = InputArray();
// PrintArray(array);
// System.Console.WriteLine(NumCounter(array));

/*
Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/

// int ConvertToNum(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         result = result + array[i] * (int)Math.Pow(10, array.Length - 1 - i);
//     }
//     return result;
// }

// Список чатов телеграм есть справа на странице семинара. Вот ссылки телеграм-каналов:
// Группа 6132: https://t.me/+nlAF2HSmPsNjYzIy
// Группа 6339: https://t.me/+o8rGKzKB9R85NzBi
// Группа 6342: https://t.me/+mdgpMzwa-_0zY2Yy
