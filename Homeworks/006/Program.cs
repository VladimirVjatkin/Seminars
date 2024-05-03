//Задача 1: 
//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.
/*

//Вот пример кода на C#, который генерирует случайный символ из заданного набора символов:
// public static char GetRandomCharacter()
// {
//     const string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
//     Random rand = new Random();
//     int num = rand.Next(0, chars.Length);
//     return chars[num];
// }



char[,] CreateMatrix(int rows, int columns)
{
    Random rand = new Random();
    char[,] matrix = new char[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = (char)rand.Next(0x0010, 0x04F);
        }
    }
    return matrix;
}

void PrintMatrix(char[,] matrix)
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

// static extern string PrintChar(char[,] Simb);
// {
//   string rezult = "";  
//   foreach (var item in Simb)
//   {
//     rezult += item;
//   }
//   return result;
// }



System.Console.Write("Input x- position of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input y - position of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("________________");
char[,] chars = new char[x,y];
chars = CreateMatrix(x,y);
PrintMatrix(chars);
//System.Console.WriteLine(PrintChar(chars));

string rezult = "";  
  foreach (var item in chars)
  {
    rezult += item;
  }
System.Console.Write("We give all chars to string - ");
System.Console.WriteLine(rezult);
*/

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.
/*
string UperDown(string str)
{
    string target = "";

    foreach (char c in str)
    {
        if (char.IsUpper(c))
        {
            target += char.ToLower(c);
        }
        else
        {
            target += c;
        }
    }
    
    return target;
}

System.Console.WriteLine("Please input string: ");
    string str = Console.ReadLine();
    System.Console.WriteLine(UperDown(str));

*/

//Задача 3: 
//Задайте произвольную строку. Выясните, является ли она палиндромом.
/*
bool PolindromStr(string str1)
{
int lg = str1.Length;
//System.Console.WriteLine($"length = {lg}");
//System.Threading.Thread.Sleep(3000);

for (int i = 0; i < lg/2; i++)
{
    //Console.WriteLine($"i={i}, str1[i]= {str1[i]}, str1[lg-i-1]={str1[lg-i-1]}");
	//System.Threading.Thread.Sleep(3000);

    if (str1[i]==str1[lg-i-1]) ; 
    else return false;   
}
return true;
}

Console.WriteLine("Enter polindrom strings:");
string str001 = Console.ReadLine();
System.Console.Write("We control polidrom - ");
System.Console.WriteLine(PolindromStr(str001));

*/

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Enter strings:");
string str001 = Console.ReadLine();

//static extern string[] StringToWords(string str002);
//{
    string[] words = new string[str001.Length];
    int j = 0;
    for (int i = 0; i < str001.Length; i++)
    {
        if (str001[i] != ' ') words[j] += str001[i];
        else j++; 
    }

//}

Console.WriteLine("We reverse Words in string");
for (int k = j; k>=0; k--)
{
System.Console.Write(words[k]+" ");
}
