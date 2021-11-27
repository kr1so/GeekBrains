// Двумерные массивы.

// Как указываются:
// 1 вариант. Таблица из строк.
/* string[,]table = new string[2,3]; */
// string - тип данных
// [,] - обозначение, что у нас будет 2 размености: строки, столбцы [2,3] соответственно
// имя массива - table
// 2 вариант. Таблица из чисел(матрица).
/* int[,]matrix=new int[5,8];  */
/* string[,] table = new string[2,5];
// string,Empthy
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4];
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]
// Присвоить строке 1, столбцу 2 значение "слово". Далее цикл для вывода на печать.
table[1,2]="слово";
    for (int rows = 0; rows < 2; rows++)
    {
    for (int columns = 0; columns < 5; columns++)
        {
        System.Console.WriteLine($"-{table[rows, columns]}-");
        }   
    } */
int[,]matrix=new int[3,4];
    for (int rows = 0; rows < 3; rows++)
    {
        for (int columns = 0; columns < 4; columns++)
        {
            // Вместо rows можно также записывать привычное i, а вместо columns - j.
            // System.Console.WriteLine($"{matrix[rows, columns]}\n"); с указанием \n - нужна для перехода на новую строку. 
            System.Console.WriteLine($"{matrix[rows, columns]} ");
        }
    Console.WriteLine();
    }
