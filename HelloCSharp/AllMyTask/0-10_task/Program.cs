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
/*  int N = 5;
for (int i = -N; i <= N; i++)
    {
    Console.WriteLine(i);
    }  */
// 2-ой способ.
/*  void MinusPlus(int number)
{   
    for (int i = -number; i <=number; i++)
    {
        Console.WriteLine(i);
    }
}
MinusPlus(5);  */

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

