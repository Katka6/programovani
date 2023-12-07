// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi!");


int Fibonacci (int n)
{
    if (n == 1)
    {
        return 1;
    }
    if (n == 0)
    {
        return 0;
    }
    int x = Fibonacci (n - 1);
    int z = Fibonacci(n - 2);
    return x + z;
};

Console.WriteLine( Fibonacci(5));


int Factorial (int f)
{
    if (f == 0)
    {
        return 1;
    }


    int w = Factorial (f - 1);
    return f * w;

}


Console.WriteLine(Factorial (5));

//používat při deskových hrách ->

int[,] tictactoe = new int[,] { {2,3,5},
                                {9,8,7},
                                {8,6,3}};

   for (int l = 0; l < tictactoe.GetLength(0); l++)
{
    for (int e= 0; e < tictactoe.GetLength(1); e++)
    {
        Console.WriteLine(tictactoe[l, e]);
    };
}



 //jagged array ->
int[][] insanetictactoe = new int[] []{  new []   {2,3,5},
                                         new []   {9,8,7,65,325},
                                         new []   {8,6}};





Console.WriteLine(insanetictactoe[0][0]);

Console.WriteLine(insanetictactoe.Length);
Console.WriteLine(insanetictactoe[2].Length);





//Náhodná čísla

Random rand = new Random();
int nahoda = rand.Next();


Console.WriteLine("nahoda");
Console.WriteLine(nahoda);































