// Бинарное дерево.
// a_i = 
// a_2i
// a_2i+1

// ((4-2)*(1+3))/10
// 1 - /
// 2 - *
// 3 - 10
// и тд
/* string emp = string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
void InOrderTraversal(int position = 1)
{
    if (position<tree.Length)
    {
        int left = 2*position;
        int right = 2*position+1;
        if (left<tree.Length && ! String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        System.Console.WriteLine(tree[position]);
        if (right<tree.Length && ! String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);

    }

}
InOrderTraversal(); */