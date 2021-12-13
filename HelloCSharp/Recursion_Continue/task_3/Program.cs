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