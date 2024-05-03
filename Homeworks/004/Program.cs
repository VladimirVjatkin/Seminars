//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

/*
Start:
System.Console.Write("Input number ");
string input;
input = Console.ReadLine();
int sum = 0;
string str1 = "q";
if (str1.Equals(input)) Fprint(sum);
else
{
    int number = Convert.ToInt32(input);
    if (number > 10)
    {


        while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        if (sum % 2 == 0) Fprint(sum);
        else goto Start;

    }
    else goto Start;
}

void Fprint(int x)
{
    if (x == 0)
    {
        System.Console.Write("You write'q' = stop program");
    }
    else System.Console.Write($"You write number that sum of numbers is EVEN = {x} - stop program");

}
*/

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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

int CountNa2(int[] arr)
{

int count = 0;
for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] % 2 == 0 ) count++;
    }
    return count;
    
}

int[] array01;
array01 = CreateArray(100,100,999);
PrintArray(array01);
System.Console.Write("Count EVEN = ");
System.Console.Write(CountNa2(array01));
*/

//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
    }
    return array;
}

int[] ArrConvert(int[] array)
{
int temp = array[0];
for (int i = 0; i < array.Length/2; i++)
{
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = temp;
    temp = array[i+1];
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

int[] array01;
int[] array02;
array01 = CreateArray(11,10,99);
PrintArray(array01);
System.Console.WriteLine("We reverse our array");
array02 = ArrConvert(array01);
PrintArray(array02);


