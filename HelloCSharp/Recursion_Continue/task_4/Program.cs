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
