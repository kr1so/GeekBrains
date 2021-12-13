/* void CatalogInfo(string path, string ident = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{ident}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, ident + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{ident}{files[i].Name}");
    }
}
string path = $"C:/Users/User/Desktop/GeekBrains/HelloCSharp/Recursion_Continue";
CatalogInfo(path); */