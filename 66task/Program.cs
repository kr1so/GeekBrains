//66. Показать натуральные числа от 1 до N, N задано

// 1 вариант:
/* string NaturalNumbers(int n)
{
    return n == 1 ? "1" : NaturalNumbers(n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10)); */

//2 вариант:
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

/* string NaturalNumbers(int n)
{
   if (n==1)
   {
       return "1";
   }
    return n + " " + NaturalNumbers(n - 1);
}
System.Console.WriteLine(NaturalNumbers(20)); */

 //68. Показать натуральные числа от M до N, N и M заданы
// TO DO 
/* string NaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return Convert.ToString(m);
    }
    return  NaturalNumbers(m,n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10, 20)); */
