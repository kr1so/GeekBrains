﻿int FillArray(int[] array)
{
    array[i] = new int [52] {2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11,};
    {
        while (array[0]>=array.Length-1)
        {
             for (int i = 0; i < array.Length; i++)
             {
                 for (int j = 0; i < array.Length; j++)
                 {
                     0 <= j <= i;
                     array[j] = array[i];
                 }
             }
        }

    }

Чтобы перемешать массив a из n элементов (индексы элементов от 0 до n - 1):
  для всех i от n − 1 до 1 выполнить
       j ← случайное число 0 ≤ j ≤ i
       обменять местами a[j] и a[i]
}