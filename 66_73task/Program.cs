//66. Показать натуральные числа от 1 до N, N задано

// При помощи тернарного оператора. 
/* string NaturalNumbers(int n)
{
    return n == 1 ? "1" : NaturalNumbers(n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10)); */

//Обычным способом. 
/* string NaturalNumbers(int n)
{
   if (n==1)
   {
       return "1";
   }
    return NaturalNumbers(n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10)); */

// 67. Показать натуральные числа от N до 1, N задано

// Обычным способом.
/* string NaturalNumbers(int n)
{
   if (n==1)
   {
       return "1";
   }
    return n + " " + NaturalNumbers(n - 1);
}
System.Console.WriteLine(NaturalNumbers(20)); */

// При помощи тернарного оператора:
/* string NaturalNumber(int n)
{
    return (n == 1) ? $"1" : n + " " + NaturalNumber(n - 1);
}
System.Console.WriteLine(NaturalNumber(5)); */

//68. Показать натуральные числа от M до N, N и M заданы

// Обычным способом.
/* string NaturalNumbers(int m, int n)
{
    if (m == n) return $"{n}";
    if (n>m) return  NaturalNumbers(m,n - 1) + " " + n;
    else
    {
    return NaturalNumbers(m,n + 1) + " " + n;
    } 
}
System.Console.WriteLine(NaturalNumbers(20, 10));  */

// При помощи тернарного оператора.
/* string NaturalNumbers(int m, int n)
{
    if (m == n ) return  $"{n}" ;
    return (m>n) ? NaturalNumbers(m, n + 1) + " " + n: 
    NaturalNumbers(m, n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10, 20));   */ 

// 69. Найти сумму элементов от M до N, N и M заданы

/*  int SumOfNumbers(int m, int n)
{
    if  (m == n) return n;
    return (n>m) ? m + SumOfNumbers(m+1, n):
    n + SumOfNumbers(m, n+1);
}
 System.Console.WriteLine(SumOfNumbers(3, 1));  */

 // 2-ой способ. 
/* int SumFromMtoN(int m, int n)
{
    if (n < m)
    {
        return m + SumFromMtoN(m - 1, n);
    }    
    if (m < n)
    {
        return n+ SumFromMtoN(m, n-1);
    }
    return n;
}
System.Console.WriteLine(SumFromMtoN(3, 1)); */ 

// 70. Найти сумму цифр числа 

/* int SumOfNumbers(int a)
{
    return ( a / 10 == 0) ? a : SumOfNumbers(a/10)+SumOfNumbers(a%10);
}
 System.Console.WriteLine(SumOfNumbers(1488)); */

// 71. Функция Аккермана.

/* int FunctionAckerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    return 0;
}
System.Console.WriteLine(FunctionAckerman(3,4)); */

// 72. Написать программу возведения числа А в целую стень B

/*  int b = 10;
int a = 7;
double DegreeNumber(int a, int b)
{
    if (b == 0 ) return 1;
    if (b == 1 ) return a;
    if (b == 2) return a*a;
    return a*DegreeNumber(a, b-1);
}
for (int i = 0; i <= b; i++)
    {
    System.Console.Write($"{DegreeNumber(a, i)} ");
    }   */
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем 

// Метод для ввода чисел от пользователя. 
/* string EnterToProgram()
{
    int count1 = 5;
    System.Console.WriteLine("Введите первое число");
    int n1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите второе число");
    int m1 = Convert.ToInt32(Console.ReadLine());
    string result = $"Вы ввели числа {n1} и {m1} ";
    return result;
}  */
/* int count1 = 10;
System.Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int m1 = Convert.ToInt32(Console.ReadLine());
string result = $"Вы ввели числа {n1} и {m1}";
System.Console.WriteLine(result);
int Summary(int n, int m, int count)
    {

    if (count == 0) return n;
    if (count == 1) return m;
    return Summary(n, m, count - 1) + Summary(n, m, count - 2);
    }
for (int i = 0; i < count1; i++)
    {
    System.Console.Write($"{Summary(n1, m1, i)} ");
    } */