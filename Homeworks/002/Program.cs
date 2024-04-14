//
//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
void CheckIfDevides(int num)
{
    if(num % 23 == 0 && num % 7 == 0)
    {
        System.Console.WriteLine($"YES, we can divide {num}/23={num/23} and {num}/7={num/7}");
        
    }
    else
    {
        System.Console.WriteLine($"NO - not possible to divide {num}/23 && {num}/7 ");
    }
}


Console.Write("Input number that we can divide 23 and 7: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num);
*/

// Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
/*
int Coordinats(int xx, int yy)
{
    if(xx==0 || yy ==0) return 5;
    if(xx>0 && yy >0) return 1;
    if(xx<0 && yy >0) return 2;
    if(xx<0 && yy <0) return 3;
    if(xx>0 && yy <0) return 4;
   else return 0;     
}

Console.Write("Input coordinate x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate y:  ");
int y = Convert.ToInt32(Console.ReadLine());
int number = Coordinats(x, y);
if (number==5) Console.WriteLine("dot is on line x or y");
else System.Console.WriteLine($"square number is --- {number}");
*/

// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
/*
void Max(int num)
{
if (num>10 && num<99)
{
int ed = num % 10;
int dec = num / 10;
    if (ed==dec) 
    { Console.WriteLine($"the same: {ed} = {dec}");
        return;
    }
    if (ed>dec) Console.WriteLine($"Max second: {ed}");
    else Console.WriteLine($"Max first: {dec}");
}
else System.Console.WriteLine("not coorect number!!!!!!!" );
}

Console.Write("Input number between 10 and 99: ");
int x = Convert.ToInt32(Console.ReadLine());
Max(x);
*/
//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
//Variant 1
// Console.Write("Input any natural number please: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int temp = 0;

// for(int i=0; x>0; i++)
// {
//     temp = x % 10;
//     System.Console.Write($"{temp},");
//     x=x/10;
// }

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
//Variant 2

Console.Write("Input any natural number please: ");
string numstr = Console.ReadLine();
int len = numstr.Length;

System.Console.Write($"Numbers with comma is = ");

for(int i=0; i<len; i++)
{
  
    System.Console.Write($"{numstr[i]},");

}

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
//Variant 3
/*
badnumber:
Console.Write("Input any natural number please: ");
string numstr = Console.ReadLine();
int len = numstr.Length;

// control if it is number - but only int
int n;
bool isNumeric = int.TryParse(numstr, out n);
System.Console.WriteLine($"this is number? = {n}, {isNumeric}");
if (isNumeric == false) 
{System.Console.WriteLine("please try next time");
System.Threading.Thread.Sleep(3000);
goto badnumber;
}
System.Console.Write($"Numbers with comma is = ");

for(int i=0; i<len; i++)
{
  
    System.Console.Write($"{numstr[i]},");

}
*/
