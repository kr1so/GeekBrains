﻿//0. Вывести квадрат числа
//int x = 2;
//int result=Math.Pow(x, 2);
//Console.WriteLine(result);

//1. По двум заданным числам проверять является ли первое квадратом второго
/*int x = 4;
int y = 2;
if (y*y==x)
{
   Console.WriteLine("ok");
}
else
{
    Console.WriteLine("not ok");
}*/
//-------------------------
/* double f(double x )
{
    double result = x*x;
    return result;
}
double res=f(5);
Console.WriteLine(res); */

//2. Даны два числа. Показать большее и меньшее число
/*
int a = 2;
int b = 4;
int min = 0;
int max = 0;
if (a<b)
{
min = a;
max = b;
Console.WriteLine(min, max);
}
else
{
min = b;
max = a;
} 
Console.WriteLine(min, max);
*/

//3. По заданному номеру дня недели вывести его название
/*
int day = 1;
string zadanie(int day)
string s = String.Empty
{
if (day == 1) return 'понедельник';
if (day == 2) return 'вторник  ';
if (day == 3) return 'среда';
if (day == 4) return 'четверг';
if (day == 5) return 'пятница';
if (day == 6) return 'суббота';
if (day == 7) return 'воскресенье';
}
else s = "день задан неверно"
Console.WriteLine(s);*/


//4. Найти максимальное из трех чисел
/*
int number1=1;
int number2=2;
int number3=3;
int max =  number1;
if (number2>max) max = number2;
if (number3>max) max = number3;
Console.WriteLine(max);*/

/* //5. Написать программу вычисления значения функции y=f(a)
 int y( int a);
 {
return a*a*a;
 }
 int c = y(2)
 Console.WriteLine(c);*/

//6. Выяснить является ли число чётным
/*int number = 201;
if(number % 2 == 0)
{
 Console.WriteLine("четное");
}
else
{
   Console.WriteLine("не четное");
}*/

//7. Показать числа от -N до N
// 1-ый способ.
/* int N = 5;
for (int i = -N; i <= N; i++)
    {
    Console.WriteLine(i);
    } */
// 2-ой способ.
/* void MinusPlus(int number)
{   
    for (int i = -number; i <=number; i++)
    {
        Console.WriteLine(i);
    }
}
MinusPlus(5); */

//8. Показать четные числа от 1 до N

// 1-ый способ.
/* int N = 5;
for (int i = 1; i <= N; i++)
    { 
    if (i % 2 == 0) Console.WriteLine(i);
    }  */
// 2-ой способ.

/* void EvenNumber (int N)
{
    for (int i = 1; i <= N; i++)
    { 
    if (i % 2 == 0) Console.WriteLine(i);
    } 
}
EvenNumber(20); */

//9. Показать последнюю цифру трёхзначного числа
// можно также сделать через едсятки - я пока не думала как

// 1-ый способ
/*int number= 213;
string text = Convert.ToString(number);
Console.WriteLine (text[2]);*/

// 2-ой способ.
/* void LastNumber (int number)
   {
   string text = Convert.ToString(number);
   Console.WriteLine (text[2]);
   }
LastNumber(247); */

//10. Показать вторую цифру трёхзначного числа

// 1-ый способ
/*int number= 212;
 string text = Convert.ToString(number);
 Console.WriteLine (text[1]);*/

// 2-ой способ
/* void LastNumber (int number)
    {
    string text = Convert.ToString(number);
    Console.WriteLine (text[1]);
    }
 LastNumber(213); */

//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
/* void Method1 (int min, int max)
{
    int[] arr = {min, max+1};
    for (int i = 0; i <= arr.Length; i++)
    {
     System.Console.WriteLine($"{arr}");  
    }
}
/* int PrintNumber(int z)
    {
    int n = z/10;
    int m = z%10;
        if (n>m) return n;
        else return m;
    }  

Method1(10,99); */



/* int x = 10;
int y = 99;
int z = new Random().Next(x, y+1);
System.Console.WriteLine($"Число из отрезка {z}");
int PrintNumber(int z)
    {
    int n = z/10;
    int m = z%10;
        if (n>m) return n;
        else return m;
    } 
System.Console.Write("Наибольшая цифра числа = ");
Console.WriteLine(PrintNumber(z));*/

//13. Удалить вторую цифру трёхзначного числа
/* int number = 423;
int DelNum(int number)
    {
        int z=number/100;
        int m=number%10;
        int result = (z*10)+m;
        return result;
    }
System.Console.Write(DelNum(number)); */
//код от панды 
/* int[] arr = new int[10];
int count = 0;
for (int i =0;i <arr.Length;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());

}
for (int i =0;i <arr.Length;i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count); */
/* //сплит делит строку на маленькие строки по пробелам
string numbers = Console.ReadLine();
string[] num = numbers.Split(' ');
// затем сконвертировать из строки в число и сравнить положительные, отрицательные, нулевые задачи */


//14.Выяснить, кратно ли число заданному, если нет, вывести остаток. 
//доделать задачу, здесь 2 варианта, первый - доработать
/*int a = 110;
int b = 60;

string Method1(int a, int b)
{
    string text = string.Empty;

    if (a > b)
    {
        if (a % b == 0)
        {
            text = "кратно";
        }
        else
        {
            int c = a % b;
            text = $"{c}";
        }
    }
    else
    {
        text = "неверно заданы числа";
    }
    return text;

}
System.Console.WriteLine(Method1(a, b));*/



/* 
    void Method1(int a, int b)
    {
        if (a>b)
        {
            if (a%b == 0)
            {   
            System.Console.WriteLine("кратно");
            }
            else
            {
            int c = a%b;
            System.Console.WriteLine(c);
            }
        }
        else
        {
             System.Console.WriteLine("неверно заданы числа");
        }
    }
    Method1(a,b); */

/*   int Method1(int a, int b)
  {
  if (a%b == 0)
  {   int result = ;
      return  result;
  } */

//15.Найти третью цифру числа или сообщить, что её нет*

/* int LastNumber (int i)
    {
    int n = i %1000;
    int m = i%100;
    int g = (n - m)/100;
    return g;
    }
 System.Console.WriteLine(LastNumber(2345)); */

//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
/* string Days (int day)
{
    string DayOfWeek = string.Empty;
    string nullResult = "Введи число от 1 до 7, чтобы узнать, является ли оно выходным днём";
    if (day == 1) DayOfWeek = $"Вы ввели число {day} - это понедельник. Это не выходной день"; 
    if (day == 2) DayOfWeek =  $"Вы ввели число {day} - это вторник. Это не выходной день"; 
    if (day == 3) DayOfWeek =  $"Вы ввели число {day} - это среда. Это не выходной день"; 
    if (day == 4) DayOfWeek =  $"Вы ввели число {day} - это четверг. Это не выходной день"; 
    if (day == 5) DayOfWeek =  $"Вы ввели число {day} - это пятница. Это не выходной день"; 
    if (day == 6) DayOfWeek =  $"Вы ввели число {day} - это суббота. Это выходной день"; 
    if (day == 7) DayOfWeek =  $"Вы ввели число {day} - это воскресенье. Это выходной день"; 
    if (day < 1 || day > 7) return nullResult;
    return DayOfWeek;
}
System.Console.WriteLine(Days(6));  */

// Метод со считыванием числа от пользователя. 
/* string Days ()
{
    System.Console.WriteLine("Введи число от 1 до 7, чтобы узнать, является ли оно выходным днём");
    int day = Convert.ToInt32(Console.ReadLine());
    string DayOfWeek = string.Empty;
    string nullResult = "Введи число от 1 до 7, чтобы узнать, является ли оно выходным днём";
    if (day == 1) System.Console.WriteLine($"Вы ввели число {day} - это понедельник. Это не выходной день"); 
    if (day == 2) System.Console.WriteLine($"Вы ввели число {day} - это вторник. Это не выходной день"); 
    if (day == 3) System.Console.WriteLine($"Вы ввели число {day} - это среда. Это не выходной день"); 
    if (day == 4) System.Console.WriteLine( $"Вы ввели число {day} - это четверг. Это не выходной день"); 
    if (day == 5) System.Console.WriteLine( $"Вы ввели число {day} - это пятница. Это не выходной день"); 
    if (day == 6) System.Console.WriteLine($"Вы ввели число {day} - это суббота. Это выходной день"); 
    if (day == 7) System.Console.WriteLine($"Вы ввели число {day} - это воскресенье. Это выходной день"); 
    if (day < 1 || day > 7) return nullResult;
    return DayOfWeek;
}
Days(); */
// 17. По двум заданным числам проверять является ли одно квадратом другого.
/* string SquadFunction(int number1, int number2)
{
    int squad1 = number1 * number1;
    int squad2 = number2 * number2;
    string result1 = $" Число является квадратом другого числа";
    string result2 = $"Число является не квадратом другого числа";
    if (squad1 == number2) return result1;
    if (squad2 == number1) return result1;
    else return result2;
}
System.Console.WriteLine(SquadFunction(4, 2)); */

//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Стихийный способ. 
// f - false, t - true
// x y result
// ----------- result = решение для дизъюнкции
// f f f
// f t t
// t t t
// t f t
/* bool
x = false, y = false;
System.Console.WriteLine(!(x || y) == (!x && !y));
x = false; y = true;
System.Console.WriteLine(!(x || y) == (!x && !y));
x = true; y = true;
System.Console.WriteLine(!(x || y) == (!x && !y));
x = true; y = false;
System.Console.WriteLine(!(x || y) == (!x && !y)); */
// Методом. 
/* bool Logical(bool x, bool y)
{
    return (!(x || y) == (!x && !y));
}
System.Console.WriteLine(Logical(false, false)); 
System.Console.WriteLine(Logical(false, true)); 
System.Console.WriteLine(Logical(true, true)); 
System.Console.WriteLine(Logical(true, false));  */
// С преобразованием из числа в булевое значение
/* bool Logical(bool x, bool y)
{
    return (!(x || y) == (!x && !y));
}
bool ConvertIntToBool(int arg)
{
    return arg == 1;
}
//System.Console.WriteLine(ConvertIntToBool(0));
//System.Console.WriteLine(ConvertIntToBool(1));
bool res = true;
for (int i = 0; i <= 1; i++)
{
    for (int j = 0; j <= 1; j++)
    {
        // За счет конъюнкции идет умножение каждого из значений и находится true/false выражения
        res = res && Logical(ConvertIntToBool(i), ConvertIntToBool(j));
    }
}
System.Console.WriteLine(res); */
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//24. Найти кубы чисел от 1 до N

// здесь показано решение только поиска кубов в кратком варианте
/* int N = 4;
int cube = N*N*N;
System.Console.WriteLine(cube); */

//здесь метод поиска куба ЧИСЛА, доработать до корректности
/*  int Cube (int N)
{   
    int cube = 0;
    for (int i = 1; i <= N; i++)
    {
        cube += (N*N*N)*i;
    }
     return cube;
}
System.Console.WriteLine(Cube(2)); */

//25. Найти сумму чисел от 1 до А
/* int n = 3;
int summary = (n *(n+1))/2;
System.Console.WriteLine(summary); */

/* int Sum (int A)
{   
    int summary = 0;
    for (int i = 1; i <= A; i++)
    {
        //summary = summary + i;
        summary += i;
    }
     return summary;
}
System.Console.WriteLine(Sum(3));
 */
//26. Возведите число А в натуральную степень B используя цикл
