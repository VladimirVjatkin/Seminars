
// **Задача 1:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

void FromMtoN(int m, int n)
{
    if (m > n)
    {
        FromMtoN(m - 1, n);
        System.Console.Write(m + " ");
    }
    else if (n > m)
    {
        FromMtoN(m, n - 1);
        System.Console.Write(n + " ");
    }
    else System.Console.Write(m + " ");
}


System.Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
FromMtoN(m, n);



// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/*
static int AckermannF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannF(m - 1, 1);
    }
    else
    {
        return AckermannF(m - 1, AckermannF(m, n - 1));
    }
}

System.Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int result = AckermannF(m, n);
Console.WriteLine($"Result AccermannFunction is for m={m} and n={n} = {result}");
*/

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


/*
void PrintArr(int[] arr)
{
    if (arr.Length > 0)
    {
        PrintArr(arr.Skip(1).ToArray());
        System.Console.Write(arr[0] + " ");
    }

}
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
PrintArr(arr);
*/