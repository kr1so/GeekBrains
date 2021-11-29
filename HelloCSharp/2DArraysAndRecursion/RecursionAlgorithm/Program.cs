
// Матрица строк. 
/* string[,] table = new string[2,5];
// string,Empthy
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4];
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]
table[1,2]="слово";
    for (int rows = 0; rows < 2; rows++)
    {
    for (int columns = 0; columns < 5; columns++)
        {
        System.Console.Write($"-{table[rows, columns]}-");
        }   
        System.Console.WriteLine();
    }   */
/* int[,] matrix = new int[3, 4];

// Матрица чисел.
for (int rows = 0; rows < 3; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine();
} */

//Ввод нового функционала.
/* int[,] matrix = new int[3, 4];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine();
}  */
// Составление методов с новым функционалом GetLength. 
void PrintArray(int[,] matrica)
{

    for (int i = 0; i < matrica.GetLength(0); i++)
    {
        for (int j = 0; j < matrica.GetLength(1); j++)
        {
            System.Console.Write($"{matrica[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,]matrica)
{
    for (int i = 0; i < matrica.GetLength(0); i++)
    {
        for (int j = 0; j < matrica.GetLength(1); j++)
        {
            matrica[i,j] = new Random().Next(1,10);
        }
    }
}
int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);