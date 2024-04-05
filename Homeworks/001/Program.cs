/* Console.Write("Tipe first number = ");
int d1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Tipe second number = ");
int d2 = Convert.ToInt32(Console.ReadLine());

if (d1 > d2) Console.WriteLine($"First number {d1} is bigger then second number {d2}");
else Console.WriteLine("First number {d1} is less then second number {d2}");
Console.Write("Tipe first number = ");
    int d1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Tipe second number = ");
    int d2 = Convert.ToInt32(Console.ReadLine());

    if (d1 > d2) Console.WriteLine($"First number {d1} is bigger then second number {d2}");
    else 
    {   if (d1==d2) Console.WriteLine("First number {d1} == second number {d2}");
        else Console.WriteLine("First number {d1} is less then second number {d2}");    
    }




*/

// Задание 1
/* using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber < secondNumber) Console.WriteLine("второе число больше");
        else if (firstNumber == secondNumber) Console.WriteLine("числа равны");
            else Console.WriteLine("первое число больше");
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 12;
            secondNumber = 11;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
} */

// Задание 2 - макс из 3 чисел
/*
using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже
    int max = a;
    if ( b>max ) max=b;
    if ( c>max ) max=c;
    return max;

    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 550;
           b = 66;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}
*/
// Задание 3 - 
using System;

/*
class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
        if (number%2==0) Console.WriteLine("четное");
        else Console.WriteLine("нечетное");
    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 9999;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}
*/

//Задание 4
using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже
        int i = 1;
        for (i = 1; i <= number; i++)
            if (i % 2 == 0)
            {
                Console.Write($"{i}");
                Console.Write(" ");
            }

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 2000;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}