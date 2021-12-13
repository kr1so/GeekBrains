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
