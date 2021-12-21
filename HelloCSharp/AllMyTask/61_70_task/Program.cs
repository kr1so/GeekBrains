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