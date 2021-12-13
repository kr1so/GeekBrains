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