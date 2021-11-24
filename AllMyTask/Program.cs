//0. Вывести квадрат числа
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
/* int i = 1254;
if (i > 100 &&
    {
}
else
{
} */

 
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