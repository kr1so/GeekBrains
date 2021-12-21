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
