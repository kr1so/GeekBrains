// Задача 1.
// Подход 1.
/* string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
return result;
}
System.Console.WriteLine(NumbersFor(4, 8)); */
// Подход 2.
/* string NumbersFor(int a, int b)
{
    if (a<=b)
    {
        return $"{a} " + NumbersFor(a+1, b);
    }
    else
    {
        return string.Empty;
    }
}*/
// Подход 3.
/* string NumbersFor(int a, int b)
{
    return (a<=b) ? $"{a} " + NumbersFor(a+1, b): string.Empty;
}
System.Console.WriteLine(NumbersFor(2, 8)); */

// Задача 2.
// Подход 1.
/* string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
return result;
}
System.Console.WriteLine(NumbersFor(8, 4));  */
// Подход 2.
/* string NumbersFor(int a, int b)
{
    if (a>=b)
    {
        return $"{a} " + NumbersFor(a-1, b);
    }
    else
    {
        return string.Empty;
    }
}
System.Console.WriteLine(NumbersFor(8, 4));   */
// Подход 3.
/* string NumbersFor(int a, int b)
{
    return (a>=b) ? $"{a} " + NumbersFor(a-1, b): string.Empty;
}
System.Console.WriteLine(NumbersFor(17, 5)); */

// Задача 3.
// Подход 1.
/* int Sum(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;  
}
System.Console.WriteLine(Sum(2));  */
// Подход 2.
/* int Sum (int n)
{
    if (n == 0) return 0;
    else
    {
        return n + Sum(n-1);
    }
}
System.Console.WriteLine(Sum(5));   */
// Подход 3.
/* int Sum (int n)
{
    return (n == 0) ? 0 : n + Sum(n-1);
}
System.Console.WriteLine(Sum(5));   */
// Задача 4.
// Подход 1.
/* int Factorial(int n)
{
int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= i;
}
return result;
}
System.Console.WriteLine(Factorial(5)); */
// Подход 2.
/* int Factorial(int n)
{
    if (n==0) {
    return 0;
    }

    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}
System.Console.WriteLine(Factorial(5));  */
// Подход 3.
/* int Factorial(int n)
{
    if (n==0) return 0;
    return (n == 1) ? 1:  n * Factorial(n - 1);
}
System.Console.WriteLine(Factorial(5));  */

// Задача 5.
// Подход 1. 
/* int Degree(int a, int n)
{
int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= a;
}
return result;
}
System.Console.WriteLine(Degree(4, 2));  */
//Подход 2.
/* int Degree(int a, int n)
{
    if (n==0) return 1;
    else
    {
        return Degree(a, n-1) * a;
    }
}
System.Console.WriteLine(Degree(2, 2));  */
// Подход 3.
/* int Degree(int a, int n)
{
    return (n==0) ? 1 : Degree(a, n-1) * a;
}
System.Console.WriteLine(Degree(5, 2));  */
//Подход 4.
/* int Degree(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return Degree(a * a, n / 2);
    else return Degree(a, n - 1) * a;
}
System.Console.WriteLine(Degree(2, 28)); */

// Задача 6.
// Подход 1.
/* char[] a = { 'a', 'b', 'c', 'd' };
int count = a.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int e = 0; e < count; e++)
        {
            for (int f = 0; f < count; f++)
            {
                for (int k = 0; k < count; k++)
                {
                    System.Console.WriteLine($"{n++,-5}{a[i]}{a[j]}{a[e]}{a[f]}{a[k]}");
                }
            }
        }
    }
} */
// Подход 2.
/// TO DO
void FindWords(string alphabet, char[] word, int length = 0)
{
    int n = 1;
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new string(word)}"); return;
    }

}
FindWords("asdwdasd", new char[6]);