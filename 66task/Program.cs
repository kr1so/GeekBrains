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
/*  string NaturalNumbers(int m, int n)
{
    if (m == n ) return  $"{n}" ;
    return (m>n) ? NaturalNumbers(m, n + 1) + " " + n: 
    NaturalNumbers(m, n - 1) + " " + n;
}
System.Console.WriteLine(NaturalNumbers(10, 20));   */
// 69. Найти сумму элементов от M до N, N и M заданы

/* string SumOfNumbers(int m, int n)
{
    int sum = m+(m+1);
    return (m == n) ? $"{n}" : SumOfNumbers(m, sum) + " " + n;

}
 System.Console.WriteLine(SumOfNumbers(5, 7)); 
 */
// 70. Найти сумму цифр числа 
/* 
 int SumOfNumbers(int a)
{
    int sum = a%10;
    int sum2 = a/10;
    return ( a % 10 == 0) ? a : SumOfNumbers(sum2)+sum;
}
 System.Console.WriteLine(SumOfNumbers(1136)); */

// 71. Функция Аккермана.

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    return 0;
}
System.Console.WriteLine(FunctionAckerman(3,4));

// 72. Написать программу возведения числа А в целую стень B
//Возведение в степень - умножение числа само на себя

/* 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем */

// Метод для ввода чисел от пользователя. 
/* string EnterToProgram()
{
    System.Console.WriteLine("Введите первое число");
    int N = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите второе число");
    int M = Convert.ToInt32(Console.ReadLine());
    string result = $"Вы ввели числа {N} и {M} ";
    return result;
} */
//System.Console.WriteLine(EnterToProgram());


/// TO DO
// Метод для вычисления сложения.
/* double  Summary(int N, int M)
{
    int count = 5;
    if (N == 0 || N == 1 && M == 0 || M == 1 ) return 1;
    else return Summary (N - 1,  M-1) + Summary(N - 2,  M-2) ;
    for (int i = 1; i < count; i++)
        {
        int j = i;
        j++;
        string result = $"{i} число = {Summary(N, M)}";
        }
}
System.Console.WriteLine(Summary(2, 3));  */

//1. Задача от Сергея.
// пустая подпоследовательность - тоже является последовательностью
//найти длину наибольшей общей последоловательности
/* int[] array1 = { 1, 2, 3, 9, 5 };
int[] аrray2 = { 1, 2, 9, 5, 4, 3 };
int Length(int[] array1, int[] аrray2)
{
    int counter = 0;
    int i = 0;
    for (int j = 0; j <= array1.Length; j++)
    {
        if (array1[i] == аrray2[j])
        {
            counter++;
            i++;
        }
        else 
        {
            j--;
            i++;
        }
    }
    return counter;
}
System.Console.WriteLine(Length(array1,аrray2)); */


//правильный ответ 4

