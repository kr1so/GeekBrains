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
System.Console.WriteLine(NaturalNumbers(10, 20)); */

// 71. Функция Аккермана.
// TO DO
double A(int m, int n)
{

    //double result1 = Convert.ToDouble(n+1);
    //double result2 = Convert.ToDouble(A(m - 1, 1));
    //double result3 = Convert.ToDouble(A(m - 1, A(m, n - 1)));

    if (m == 0) return Convert.ToDouble(n+1);
    if (m > 0 && n == 0) return Convert.ToDouble(A(m - 1, 1));;
    //if (m > 0 && n > 0) return Convert.ToDouble(A(m - 1, A(m, n - 1)));
    return ;
}
System.Console.WriteLine(A(4,0)); 