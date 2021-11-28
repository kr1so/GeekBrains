int FillArray(int[] array)
{
    array[i] = new int [52];
    array[i] = {2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
    while (array[0]>=array.Length)
        {
             for (int i = 0; i < array.Length; i++)
             {
                 for (int j = 0; j < array.Length; j++)
                 {
                     0 <= j <= i;
                     array[j] = array[i];
                 }
             }
        }
    return array[i];
    }
}
System.Console.WriteLine(FillArray);
