//1. Задача от Сергея.
// пустая подпоследовательность - тоже является последовательностью
//найти длину наибольшей общей последовательности
/*  int[] array1 = { 1, 2, 3, 9, 5 };
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
System.Console.WriteLine(Length(array1,аrray2));  */
