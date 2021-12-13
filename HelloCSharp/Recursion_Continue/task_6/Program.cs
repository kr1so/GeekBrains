
// Задача 6.
// Подход 1.
/* char[] a = { 'a', 'b', 'c', 'd' };
int count = a.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int e = 0; e < count; e++)
        {
            for (int f = 0; f < count; f++)
            {
                for (int k = 0; k < count; k++)
                {
                    System.Console.WriteLine($"{n++,-5}{a[i]}{a[j]}{a[e]}{a[f]}{a[k]}");
                }
            }
        }
    }
} */

// Подход 2.
/* int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new string(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length]=alphabet[i]; 
        FindWords(alphabet, word, length+1);
    }
}
FindWords("арбуз", new char[5]); */