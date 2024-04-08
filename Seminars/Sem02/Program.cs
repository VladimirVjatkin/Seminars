// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// void NumToQuad(int num)
// {
// System.Console.WriteLine(num*num);

// }

// int num01 = Convert.ToInt32(Console.ReadLine());

// NumToQuad(num01);

// int NumToQuadInt(int num)
// {
//     System.Console.WriteLine("Input number: ");
//     int a = Convert.ToInt32(Console.ReadLine());
// }


// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int DelSecDig (int num)
// {
// if (num>99 && num<1000)
// {
// int ed = num % 10;
// int sot = num / 100;

// return sot*10+ed;


// }
// else { 
//     Console.WriteLine("not tri znaka");
//     return 0;
//     }
// }

// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(DelSecNum(a));
// System.Console.WriteLine(a);

////////////////////////
///
// int DeleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// void DeleteSecondDigitVoid(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(sot * 10 + ed);
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // System.Console.WriteLine(DeleteSecondDigit(num));
// DeleteSecondDigitVoid(num);
// ////////////////////

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int SecondToThirdPower (int num)
// {
//     int result=1;
// if (num>99 && num<1000)
// {
// int ed = num % 10;
// int dec = num/10%10;
// for (int i = 0; i < ed; i++)
// {
//     result=resultr*dec;
// }

// return ;

// }
// else { 
//     Console.WriteLine("not tri znaka");
//     return 0;
//     }
// }

// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(SecondToThirdPower(a));
// System.Console.WriteLine(a);
///////////////////////////////////////////////
///
// int SecondToThirdPower(int num)
// {
//     if (num >= 100 && num <= 999)// a b 456 2 3 
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SecondToThirdPower(num));

///////////////////////////
///
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void CheckNum(int num1, int num2)
// {
//     if (num1%num2==0)
//     {
//         System.Console.WriteLine($"{num1},/ {num2} - yes");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1},/ {num2} - NO");
//     }
    
/*  
// }

// Console.Write("Input three-digit number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input three-digit number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckNum(int num1, int num2);
// /???????????????????????????????????????????
// /
*/
void CheckIfDevides(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}/{num2} = {num1/num2} -> yes");
        System.Console.WriteLine("Divide without drobnych");
    }
    else
    {
        System.Console.WriteLine($"{num1} / {num2} -> no, ostatok {num1 % num2}");
    }
}


Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());//25
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num1, num2);

//???????????????

