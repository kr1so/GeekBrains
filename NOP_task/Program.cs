//1. Задача от Сергея.
//Найти длину наибольшей общей последовательности
/* int LengthNumbers(int[] array1, int[] аrray2, int countArray1, int countArray2)
{
    if (countArray1 == array1.Length || countArray2 == аrray2.Length) return 0;
    else
    {
        return (array1[countArray1] == аrray2[countArray2]) 
        ? 1 + LengthNumbers(array1, аrray2, countArray1 + 1, countArray2 + 1) :
        Math.Max(LengthNumbers(array1, аrray2, countArray1 + 1, countArray2),
        LengthNumbers(array1, аrray2, countArray1, countArray2 + 1));
    }
}
int[] array1 = { 1, 2, 3, 9, 5, 7 };
int[] array2 = { 1, 2, 9, 5, 4, 3 };
Console.WriteLine(LengthNumbers(array1, array2, 0, 0)); */
