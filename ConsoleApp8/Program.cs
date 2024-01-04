

//Console.WriteLine("vyber soubor");
//string path = Console.ReadLine();

//try
//{
//  string text = File.ReadAllText(path);
// Console.WriteLine(text);
//}
//catch (Exception ex)
//{
//  Console.WriteLine("ne, toto je tvá chyba:");
//   Console.WriteLine(ex);
//}
















static string GetPathFromUser()
{
    Console.WriteLine("Enter path");
    string path = Console.ReadLine();
    return path;
}

static void PrintErrorMessage()
{
    Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
    return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
    try
    {
        string contents = GetFileContents(path);
        Console.WriteLine(contents);
    }
    catch (Exception e)
    {
        PrintErrorMessage();
    }
}

static void UserReadFile()
{
    string path = GetPathFromUser();

    PrintFileContents(path);
}


UserReadFile();














