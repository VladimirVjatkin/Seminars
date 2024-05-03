// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
void OneTon(int n)
{
    if(n>0)
    {
        OneTon(n-1);
       System.Console.WriteLine(n+"");
    }

}

OneTon(6);
*/

// **Задача 67:** Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

// int Sum(int num)
// {
//     If (num>0)
//     {
//         return num%10 + Sum(num/10);
//     }
//     return 0;
// }


/*
int Sum(int num)
{
    if(num > 0)
    {
        return Sum(num / 10) + num % 10;
    }
    return 0;
}
int result = Sum(453);
System.Console.WriteLine(result);
*/

// **Задача 65:** Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
/*
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


FromMtoN(5, 5);
*/

// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Pow(int a, int b)
{
    if (b > 0)
    {
        return a * Pow(a, b - 1);
    }
    return 1;
}

int result = Pow(2, 5);
System.Console.WriteLine(result);


